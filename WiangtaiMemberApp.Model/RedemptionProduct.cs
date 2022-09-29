using System;
namespace WiangtaiMemberApp.Model
{
    public class RedemptionProduct
    {
        public Guid RedemptionProductID { get; set; }
        public Guid RedemptionCategoryID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<bool> TnGoVoucher { get; set; }
        public Nullable<decimal> VoucherReloadAmount { get; set; }
        public Nullable<bool> Available { get; set; }
        public Nullable<Guid> ThumbnailID { get; set; }
        public Nullable<Guid> ImageID { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Nullable<System.Guid> CurrencyID { get; set; }
        public Nullable<int> ProductQuantity { get; set; }
        public Nullable<int> RedeemPoint { get; set; }
        public Nullable<decimal> RedeemAmount { get; set; }
        public Nullable<decimal> SubsidyAmount { get; set; }
        public Nullable<int> PartnerID { get; set; }
        public Nullable<int> StockInHand { get; set; }
        public Nullable<byte> intProductType { get; set; }
        public Nullable<int> intSorting { get; set; }
        public Nullable<DateTime> dtStartDate { get; set; }
        public Nullable<DateTime> dtEndDate { get; set; }
        public Nullable<decimal> decProductCost { get; set; }
        public Nullable<decimal> decDeliveryCost { get; set; }
        public Nullable<decimal> decTxnCost { get; set; }
        public Nullable<decimal> decInsuranceCost { get; set; }
        public string strWeight { get; set; }
        public string strWidth { get; set; }
        public string strHeight { get; set; }
        public string strLength { get; set; }
        public Nullable<decimal> decFeeValue { get; set; }
        public Nullable<decimal> decDeliverySLA { get; set; }
        public Nullable<int> intMaxFrequencyPerMonth { get; set; }
        public Nullable<int> intMaximumCashbackPerMonth { get; set; }
        public Nullable<decimal> decPercentPointBalanceCheck { get; set; }
        public Nullable<decimal> decCashValue { get; set; }
        public Nullable<long> idPointCurrency { get; set; }
        public Nullable<int> intPartnerPoint { get; set; }
        public Nullable<int> idFulFillmentHouse { get; set; }
        public Nullable<Guid> idAPIKey { get; set; }
        public Nullable<Guid> idPartnerPointExchange { get; set; }
        public bool bitHotDeal { get; set; }
        public Nullable<Guid> idMerchant { get; set; }
        public Nullable<decimal> decVoucherAmt { get; set; }
        public string strBarcodeMessage { get; set; }
        public Nullable<byte> intAuthOnsite { get; set; }
        public string strAuthOnsiteCode { get; set; }
        public string strAuthOnsiteCodeHash { get; set; }
        public Nullable<int> intVoucherApprStatus { get; set; }
        public Nullable<int> IntLimitPerMember { get; set; }
        public Nullable<int> intVoucherExpiryType { get; set; }
        public Nullable<System.DateTime> dtExpiry { get; set; }
        public Nullable<int> intExpiryDays { get; set; }
        public string strPromoTitle { get; set; }
        public string strPromoDesc { get; set; }
        public Nullable<Guid> PromoPicID { get; set; }
        public string strPromoVideo { get; set; }
        public string strVoucherURL { get; set; }
        public string strTerms { get; set; }
        public Nullable<byte> RedemptionLevel { get; set; }
        public Nullable<byte> intValueType { get; set; }
        public Nullable<int> BarcodeTextType { get; set; }
        public string BarcodeFixedText { get; set; }

        public virtual ICollection<MemberRedemptionDetail> MemberRedemptionDetails { get; set; }
        public virtual RedemptionCategory RedemptionCategory { get; set; }
        public virtual ICollection<RedemptionProductDetail> RedemptionProductDetails { get; set; }
    }
}

