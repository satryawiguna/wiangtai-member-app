using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Commons;

public class Common
{
    public enum RewardType
    {
        Point = 0,
        Rebate = 1,
        Subsidy = 2,
        Coupon = 3,
        eToken = 4
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public enum MaritalStatus 
    {
        Single = 0,
        Married = 1
    }
}
