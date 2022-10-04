using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Commons;

public class Common
{
    public Common()
    {
    }

    public static async Task<SelectList> MemberTypeSelectListItem(IMemberService memberService, bool? bitPreRegister = null)
    {
        if (bitPreRegister != null)
        {
            var items = await memberService.GetAllMemberTypesByFilter(mt => mt.intCustomerType == 1 && mt.bitPreRegister == bitPreRegister.Value);

            return new SelectList(items, "MemberTypeID", "MemberTypeName");
        }
        else
        {
            var items = await memberService.GetAllMemberTypesByFilter(mt => mt.intCustomerType == 1);

            return new SelectList(items, "MemberTypeID", "MemberTypeName");
        }
    }

    public enum RewardType
    {
        Point = 0,
        Rebate = 1,
        Subsidy = 2,
        Coupon = 3,
        eToken = 4
    }
}
