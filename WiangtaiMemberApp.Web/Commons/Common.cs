using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Commons;

public class Common
{
    private readonly ILogger<Common> _logger;
    private readonly ISettingService _settingService;

    public Common(ILogger<Common> logger,
        ISettingService settingService)
    {
        _logger = logger;
        _settingService = settingService;
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

        var idSetting = _settingService.GetSettingByFilter(p => p.idSetting == id);

        return bool.Parse(idSetting.strValue);
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
