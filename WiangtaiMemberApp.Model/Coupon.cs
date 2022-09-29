using System;
namespace WiangtaiMemberApp.Model;

public class Coupon
{
    public Guid CouponID { get; set; }
    public string CouponName { get; set; }
    public Nullable<int> DiscountPercent { get; set; }
    public Nullable<decimal> DiscountAmount { get; set; }
    public string RefNoPrefix { get; set; }
    public Nullable<byte> RefNoLength { get; set; }
    public Nullable<int> QuantityLimit { get; set; }
    public Nullable<int> QuantityIssued { get; set; }
    public Nullable<System.DateTime> ValidUntil { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<LoyaltyDetail> LoyaltyDetails { get; set; }
}