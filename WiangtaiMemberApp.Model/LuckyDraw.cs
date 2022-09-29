using System;
namespace WiangtaiMemberApp.Model;

public class LuckyDraw
{
    public Guid LuckyDrawID { get; set; }
    public string ProgramName { get; set; }
    public byte DrawFrom { get; set; }
    public Nullable<byte> RangeFrom { get; set; }
    public Nullable<byte> RangeTo { get; set; }
    public byte NumberFormatType { get; set; }
    public int NumberFormat { get; set; }
    public byte DrawPeriod { get; set; }
    public Nullable<byte> WeeklyDay { get; set; }
    public Nullable<System.DateTime> DrawTime { get; set; }
    public Nullable<int> DrawFrequency { get; set; }
    public Nullable<bool> RandomDraw { get; set; }
    public DateTime EffectiveDate { get; set; }
    public Nullable<System.DateTime> ExpiryDate { get; set; }
    public Nullable<System.DateTime> NextDrawDate { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<LoyaltyDetail> LoyaltyDetails { get; set; }
}
