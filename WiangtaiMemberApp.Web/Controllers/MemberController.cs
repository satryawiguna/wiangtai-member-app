using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Request.Member;
using WiangtaiMemberApp.Web.Models.Member;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Controllers;

[Authorize]
public class MemberController : Controller
{
    private readonly ILogger<MemberController> _logger;
    private readonly IMapper _mapper;
    private readonly IMemberService _memberService;
    private readonly IConfigurationService _configurationService;

    public MemberController(ILogger<MemberController> logger,
        IMapper mapper,
        IMemberService memberService,
        IConfigurationService configurationService)
    {
        _logger = logger;
        _mapper = mapper;
        _memberService = memberService;
        _configurationService = configurationService;
    }

    public IActionResult Index()
    {
        ViewBag.MemberTypes = new SelectList(_memberService.GetAllMemberTypes(mt => mt.MemberTypeName), "MemberTypeID", "MemberTypeName");
        ViewBag.ReferenceType = new SelectList(_memberService.GetAllReferenceTypes(rt => rt.isVisible == true, rt => rt.intSort), "ReferenceTypeCode", "ReferenceTypeName");

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> GetDataMembers()
    {
        var user = (ClaimsIdentity)HttpContext.User.Identity;
        var claimUserId = user.FindFirst("UserId");
        var userId = claimUserId == null ? String.Empty : claimUserId.Value;
        //var userId = "8ab27734-a558-4f5b-bfc9-01a6c8d478a1";

        var draw = HttpContext.Request.Form["draw"].FirstOrDefault();

        int offset = Convert.ToInt32(Request.Form["start"].FirstOrDefault());
        int limit = Convert.ToInt32(Request.Form["length"].FirstOrDefault());

        int orderIndex = Convert.ToInt32(Request.Form["order[0][column]"].FirstOrDefault());
        string orderColumn = Request.Form[$"columns[{orderIndex}][name]"].FirstOrDefault() ?? String.Empty;

        string orderDirection = Request.Form["order[0][dir]"].FirstOrDefault() ?? "DESC";

        string keyword = Request.Form["general_search"].FirstOrDefault() ?? String.Empty;
        string? memberType = String.IsNullOrEmpty(Request.Form["member_type_search"].FirstOrDefault()) ? null : Request.Form["member_type_search"].FirstOrDefault();
        int referenceType = String.IsNullOrEmpty(Request.Form["reference_type_search"].FirstOrDefault()) ? 0 : Convert.ToInt32(Request.Form["reference_type_search"]);

        var pageSearchRequest = new PageSearchRequestDto()
        {
            offset = offset,
            limit = limit,
            orderColumn = orderColumn,
            orderDirection = orderDirection,
            keyword = keyword
        };

        var response = await _memberService.GetPageSearchMembersAsync(pageSearchRequest, userId, memberType, referenceType);

        return new JsonResult(new
        {
            Draw = draw,
            RecordsFiltered = response.Total,
            RecordsTotal = response.Total,
            Data = response.Data
        });
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.MemberTypes = new SelectList(_memberService.GetAllMemberTypes(mt => mt.MemberTypeName), "MemberTypeID", "MemberTypeName");
        ViewBag.ReferenceType = new SelectList(_memberService.GetAllReferenceTypes(rt => rt.isVisible == true, rt => rt.intSort), "ReferenceTypeCode", "ReferenceTypeName");

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CreateMemberVM model)
    {
        if (ModelState.IsValid)
        {
            SubmitMemberRequestDto request = _mapper.Map<SubmitMemberRequestDto>(model);
            var storeMemberAsyncResponse = _memberService.StoreMember(request);

            return RedirectToAction(nameof(Index), new { memberId = storeMemberAsyncResponse.MemberID });
        }

        ViewBag.MemberTypes = new SelectList(_memberService.GetAllMemberTypes(mt => mt.MemberTypeName), "MemberTypeID", "MemberTypeName");
        ViewBag.ReferenceTypes = new SelectList(_memberService.GetAllReferenceTypes(rt => rt.isVisible == true, rt => rt.intSort), "ReferenceTypeCode", "ReferenceTypeName");

        return View();
    }

    [HttpGet]
    public IActionResult Show(Guid memberId)
    {
        ViewBag.Member = _memberService.ShowMember(memberId);

        ViewBag.ReferenceTypes = _memberService.GetAllReferenceTypes(rt => rt.isVisible == true, rt => rt.intSort);

        return View();
    }
}

