using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Commons;

public class Common
{
    private readonly IMemberService _memberService;

    public Common(IMemberService memberService)
    {
        _memberService = memberService;
    }

    public static SelectList MemberTypeSelectListItem(bool? bitPreRegister)
    {
        if (bitPreRegister != null)
        { 
            //return new SelectList(await _memberService.GetAllMemberTypesByFilter(mt => mt.intCustomerType == 1 && mt.bitPreRegister == bitPreRegister.Value), "MemberTypeID", "MemberType1");
        }
        else
        {
            //
        }

        return null;
    }
}
