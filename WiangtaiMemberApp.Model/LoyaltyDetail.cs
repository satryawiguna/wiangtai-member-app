using System;
namespace WiangtaiMemberApp.Model;

public class LoyaltyDetail
{
    public Guid LoyaltyDetailID { get; set; }
    public Guid LoyaltyID { get; set; }
    public Nullable<System.Guid> MemberTypeID { get; set; }
    public Nullable<int> Point { get; set; }
    public Nullable<Guid> CouponID { get; set; }
    public Nullable<Guid> LuckyDrawID { get; set; }
    public Nullable<Guid> ToMemberTypeID { get; set; }
    public Nullable<int> ReferFriend { get; set; }
    public Nullable<byte> IntroducerPercent { get; set; }
    public Nullable<int> ForwardEmail { get; set; }
    public Nullable<bool> ParticipateSurvey { get; set; }
    public Nullable<bool> ParticipateQuiz { get; set; }
    public Nullable<decimal> FromAmount { get; set; }
    public Nullable<decimal> ToAmount { get; set; }
    public Nullable<Guid> CancelLoyaltyID { get; set; }
    public Nullable<byte> PointWithdraw { get; set; }
    public Nullable<bool> CouponWithdraw { get; set; }
    public Nullable<decimal> CancellationFee { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<int> MaximumPerMonth { get; set; }
    public Nullable<int> LifetimeMaximum { get; set; }

    public virtual Coupon Coupon { get; set; }
    public virtual Loyalty Loyalty { get; set; }
    public virtual LuckyDraw LuckyDraw { get; set; }
}
