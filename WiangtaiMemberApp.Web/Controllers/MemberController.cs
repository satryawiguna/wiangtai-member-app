using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Model.Request.Member;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Controllers;

[Authorize]
public class MemberController : Controller
{
    private readonly ILogger<MemberController> _logger;
    private readonly IMemberService _memberService;

    public MemberController(ILogger<MemberController> logger,
        IMemberService memberService)
    {
        _logger = logger;
        _memberService = memberService;
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

        var response = await _memberService.GetPageSearchMembersAsync(pageSearchRequest, memberType, referenceType);

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
    public async Task<IActionResult> Create([Bind("FirstName, LastName, intNoType, PassportNo, MobilePhone, Email, MemberType")] SubmitMemberRequestDto request)
    {
        if (ModelState.IsValid)
        {
            await _memberService.StoreMemberAsync(request);

            return RedirectToAction(nameof(Index));
        }

        ViewBag.MemberTypes = new SelectList(_memberService.GetAllMemberTypes(mt => mt.MemberTypeName), "MemberTypeID", "MemberTypeName");
        ViewBag.ReferenceType = new SelectList(_memberService.GetAllReferenceTypes(rt => rt.isVisible == true, rt => rt.intSort), "ReferenceTypeCode", "ReferenceTypeName");

        return View();
    }
}

