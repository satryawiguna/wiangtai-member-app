using System;
namespace WiangtaiMemberApp.Model;

public class MemberType
{
    public Guid MemberTypeID { get; set; }
    public string MemberTypeName { get; set; }
    public string MemberTypeDesc { get; set; }
    public Nullable<int> Grade { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<Guid> CurrencyID { get; set; }
    public Nullable<decimal> AnnualFee { get; set; }
    public byte ValidityPeriod { get; set; }
    public string ReferenceCode { get; set; }
    public Nullable<byte> intCustomerType { get; set; }
    public Nullable<bool> bitAllowPointTransfer { get; set; }
    public Nullable<bool> bitAllowCashTransfer { get; set; }
    public Nullable<Guid> idDocument { get; set; }
    public Nullable<bool> bitPreRegister { get; set; }
    public Nullable<bool> bitEnableEmoney { get; set; }
    public Nullable<bool> bitEnableWriteToCard { get; set; }
    public Nullable<int> intCardProtocal { get; set; }
    public Nullable<bool> bitMandatoryMemberReg { get; set; }
    public Nullable<bool> bitMandatoryNonMemberReg { get; set; }
    public Nullable<bool> bitMandatoryCardReplacement { get; set; }

    public virtual Currency Currency { get; set; }

    public virtual ICollection<Member> Members { get; set; }
    public virtual ICollection<Membership> Memberships { get; set; }
}

