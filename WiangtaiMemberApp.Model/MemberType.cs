using System;
namespace WiangtaiMemberApp.Model;

public class MemberType
{
    public Guid MemberTypeID { get; set; }
    public string MemberTypeName { get; set; }
    public string MemberTypeDesc { get; set; }
    public int? Grade { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid? CurrencyID { get; set; }
    public decimal? AnnualFee { get; set; }
    public byte ValidityPeriod { get; set; }
    public string ReferenceCode { get; set; }
    public byte? intCustomerType { get; set; }
    public bool? bitAllowPointTransfer { get; set; }
    public bool? bitAllowCashTransfer { get; set; }
    public Guid? idDocument { get; set; }
    public bool? bitPreRegister { get; set; }
    public bool? bitEnableEmoney { get; set; }
    public bool? bitEnableWriteToCard { get; set; }
    public int? intCardProtocal { get; set; }
    public bool? bitMandatoryMemberReg { get; set; }
    public bool? bitMandatoryNonMemberReg { get; set; }
    public bool? bitMandatoryCardReplacement { get; set; }

    public virtual Currency Currency { get; set; }

    public virtual ICollection<Member> Members { get; set; }
    public virtual ICollection<Membership> Memberships { get; set; }
}

