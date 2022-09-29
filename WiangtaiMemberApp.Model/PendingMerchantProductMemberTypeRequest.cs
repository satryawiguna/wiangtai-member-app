using System;
namespace WiangtaiMemberApp.Model;

public class PendingMerchantProductMemberTypeRequest
{
    public Guid idPendingMerchantProductMemberTypeRequest { get; set; }
    public Nullable<System.Guid> idMerchantProductMemberType { get; set; }
    public byte intType { get; set; }
    public Nullable<Guid> idMerchant { get; set; }
    public Nullable<Guid> idMerchantProduct { get; set; }
    public Nullable<Guid> idMemberType { get; set; }
    public string strTerm { get; set; }
    public Nullable<decimal> decOffer { get; set; }
    public string strRejectResult { get; set; }
    public byte intStatus { get; set; }
    public Nullable<DateTime> dtCreated { get; set; }
    public string strCreatedBy { get; set; }
    public Nullable<DateTime> dtModified { get; set; }
    public string strModifiedBy { get; set; }
    public Nullable<DateTime> dtValidFrom { get; set; }
    public Nullable<DateTime> dtValidTo { get; set; }

    public virtual MemberType MemberType { get; set; }
    public virtual MerchantProduct MerchantProduct { get; set; }
}
