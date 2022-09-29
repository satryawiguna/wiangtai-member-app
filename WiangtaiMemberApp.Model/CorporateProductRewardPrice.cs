using System;
namespace WiangtaiMemberApp.Model;

public class CorporateProductRewardPrice
{
    public Guid PriceID { get; set; }
    public Guid ProductRewardID { get; set; }
    public decimal FromPrice { get; set; }
    public decimal ToPrice { get; set; }
    public Nullable<byte> RewardPriceType { get; set; }
    public Nullable<decimal> FormulaPrice { get; set; }
    public Nullable<int> FormulaPoint { get; set; }
    public Nullable<decimal> Percentage { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual CorporateProductReward CorporateProductReward { get; set; }
}
