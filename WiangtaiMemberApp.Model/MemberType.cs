using System;
namespace WiangtaiMemberApp.Model;

public class MemberType
{
    public Guid MemberTypeID { get; set; }
    public string MemberType1 { get; set; }
    public string MemberTypeDesc { get; set; }
    public Nullable<int> Grade { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public Nullable<Guid> CurrencyID { get; set; }
    public Nullable<decimal> AnnualFee { get; set; }
    public Nullable<Guid> PriceTypeID { get; set; }
    public byte ValidityPeriod { get; set; }
    public Nullable<long> idPointCurrency { get; set; }
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

    public virtual ICollection<MemberGroupDetail> MemberGroupDetails { get; set; }
    public virtual PointCurrencyValue PointCurrencyValue { get; set; }
    public virtual ICollection<MemberTypeDetail> MemberTypeDetails { get; set; }
    public virtual ICollection<ProductPromotion> ProductPromotions { get; set; }
    public virtual ICollection<ProductReward> ProductRewards { get; set; }
    public virtual ICollection<CardInventory> CardInventories { get; set; }
    public virtual ICollection<CorporateProductReward> CorporateProductRewards { get; set; }
    public virtual ICollection<MemberTypeWhiteList> MemberTypeWhiteLists { get; set; }
    public virtual ICollection<MerchantProductMemberType> MerchantProductMemberTypes { get; set; }
    public virtual ICollection<PendingMerchantProductMemberTypeRequest> PendingMerchantProductMemberTypeRequests { get; set; }
    public virtual ICollection<RewardPromoMemberType> RewardPromoMemberTypes { get; set; }
}

