using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Commons;

public class Common
{
    private readonly ISettingService _settingService;

    public Common(ISettingService settingService)
    {
        _settingService = settingService;
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

    public bool EncryptCardNumber()
    {
        Guid id = new Guid("e42145cf-9544-49a8-8cd7-c3ed1b842d42");

        return bool.Parse(_settingService.GetSettingByFilter(p => p.idSetting == id)) ;
    }

    public string DoEncryptCard(string CardNumber)
    {
        try
        {
            if (EncryptCardNumber())
            {
                return Security.EncryptTextCardNumber(CardNumber);
            }
            else
            {
                return CardNumber;
            }
        }
        catch (Exception ex)
        {
            return "";
        }


    }

    public string DoDecryptCard(string CardNumber)
    {
        try
        {
            if (EncryptCardNumber())
            {
                return Security.DecryptTextCardNumber(CardNumber);
            }
            else
            {
                return CardNumber;
            }
        }
        catch (Exception ex)
        {
            return CardNumber;
        }


    }
}
