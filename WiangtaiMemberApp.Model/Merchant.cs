using System;

namespace WiangtaiMemberApp.Model;

public class Merchant
{
    public Guid MerchantID { get; set; }
    public Nullable<Guid> MerchantCategoryID { get; set; }
    public string MerchantName { get; set; }
    public string MerchantDesc { get; set; }
    public Nullable<System.Guid> LogoImageID { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<byte> Badge { get; set; }
    public bool intPublish { get; set; }
    public string strWebsite { get; set; }
    public string strPhone { get; set; }
    public bool isEVoucher { get; set; }
    public string MerchantCode { get; set; }
    public bool bitJoinGlobal { get; set; }
    public Nullable<long> idAffiliate { get; set; }
    public string PromoCodeRegister { get; set; }
    public Nullable<decimal> B2BCommPctFee { get; set; }
    public Nullable<decimal> B2BCommFixedFee { get; set; }
    public Nullable<decimal> B2BOwnUsePctFee { get; set; }
    public Nullable<decimal> B2BOwnUseFixedFee { get; set; }
    public Nullable<decimal> B2BMinVoucherPrice { get; set; }
    public Nullable<byte> B2BMaxMarketPlaceList { get; set; }
    public Nullable<byte> B2BMinVoucherQty { get; set; }
    public Nullable<long> B2BSMSTemplateId { get; set; }
    public Nullable<long> B2BEmailTemplateId { get; set; }
    public string B2B_EmailSendFrom { get; set; }
    public string B2B_EmailReplyTo { get; set; }
    public Nullable<byte> B2CMaxMarketPlaceList { get; set; }
    public Nullable<decimal> B2CMinVoucherPrice { get; set; }
    public Nullable<decimal> B2CCommPctFee { get; set; }
    public Nullable<decimal> B2CCommFixedFee { get; set; }
    public Nullable<byte> B2CMinVoucherQty { get; set; }
    public Nullable<long> B2CSMSTemplateId { get; set; }
    public Nullable<long> B2CEmailTemplateId { get; set; }
    public string B2C_EmailSendFrom { get; set; }
    public string B2C_EmailReplyTo { get; set; }
    public Nullable<int> TimeZoneID { get; set; }
    public Nullable<double> GMTOffsetValue { get; set; }
    public string Currency { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostCode { get; set; }
    public string Country { get; set; }
    public Nullable<double> Tax { get; set; }
    public Nullable<bool> MultipleCurrency { get; set; }
    public string OtherCurrency { get; set; }
    public Nullable<int> RegisterType { get; set; }

    public virtual ICollection<MerchantCategory> MerchantCategories { get; set; }
    public virtual ICollection<MerchantProduct> MerchantProducts { get; set; }
}