using System;
namespace WiangtaiMemberApp.Model;

public class Loyalty
{
    public Guid LoyaltyID { get; set; }
    public byte ProgramType { get; set; }
    public string ProgramName { get; set; }
    public DateTime ValidFrom { get; set; }
    public Nullable<DateTime> ValidTo { get; set; }
    public Nullable<Guid> CreatedBy { get; set; }
    public Nullable<DateTime> CreatedDate { get; set; }
    public Nullable<Guid> ModifiedBy { get; set; }
    public Nullable<DateTime> ModifiedDate { get; set; }
    public Nullable<Guid> MemberActivityID { get; set; }
    public Nullable<Guid> RewardFundID { get; set; }
    public Nullable<int> GracePeriod { get; set; }
    public Nullable<int> PointExpiry { get; set; }
    public Nullable<int> CalculationFrequency { get; set; }
    public Nullable<int> ProcessDay { get; set; }
    public Nullable<DateTime> Time { get; set; }
    public Nullable<DateTime> ProcessDate { get; set; }
    public Nullable<DateTime> ProcessTime { get; set; }
    public string ActivityRewardCode { get; set; }
    public Nullable<byte> intRunStatus { get; set; }
    public Nullable<byte> intStatus { get; set; }
    public Nullable<byte> intRewardType { get; set; }
    public Nullable<int> intExpiryValue { get; set; }
    public string strQuery { get; set; }
    public Nullable<byte> intDetectionFrequency { get; set; }
    public Nullable<short> intDay { get; set; }
    public Nullable<bool> IsAddPrefix { get; set; }
    public Nullable<int> intNotifyCampaign { get; set; }

    public virtual ActivityMaster ActivityMaster { get; set; }
    public virtual RewardFundMaster RewardFundMaster { get; set; }
    public virtual ICollection<LoyaltyDetail> LoyaltyDetails { get; set; }
}
