using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using WiangtaiMemberApp.Model.Request;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Controllers;

[Authorize]
public class MemberController : Controller
{
    private readonly IMemberService _memberService;

    private readonly ILogger<MemberController> _logger;

    public MemberController(IMemberService memberService,
        ILogger<MemberController> logger)
    {
        _memberService = memberService;
        _logger = logger;
    }

    public IActionResult Index()
    {
        //db.MemberTypes.OrderBy().Select(m => new SelectListItem()
        //{
        //    Text = m.MemberType1,
        //    Value = m.MemberTypeID.ToString()
        //}).ToList();

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

        string keyword = Request.Form["draw"].FirstOrDefault() ?? String.Empty;

        var pageSearchRequest = new PageSearchRequestDto()
        {
            offset = offset,
            limit = limit,
            orderColumn = orderColumn,
            orderDirection = orderDirection,
            keyword = keyword
        };

        int intNoType = Convert.ToInt32(Request.Form["filter_int_no_type"].FirstOrDefault());
        int memberType = Convert.ToInt32(Request.Form["filter_member_type"].FirstOrDefault());

        var response = await _memberService.GetPageSearchMembers(pageSearchRequest, intNoType, memberType);

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
        var memberTypes = Commons.Common.MemberTypeSelectListItem(_memberService);



        return View();
    }

    public async Task<IActionResult> Edit(string? memberId)
    {
        var member = await _memberService.GetMemberByID(memberId);

        if (member == null)
        {
            return NotFound();
        }

        return View(member);
    }
}

