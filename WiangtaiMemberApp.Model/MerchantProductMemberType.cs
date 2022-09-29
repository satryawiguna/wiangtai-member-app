using System;
using System.Reflection;

namespace WiangtaiMemberApp.Model;

public class MerchantProductMemberType
{
    public Guid idMerchantProductMemberType { get; set; }
    public Guid idMerchantProduct { get; set; }
    public Guid idMemberType { get; set; }
    public Nullable<decimal> decOffer { get; set; }
    public Nullable<DateTime> dtValidFrom { get; set; }
    public Nullable<DateTime> dtValidTo { get; set; }
    public string strTerm { get; set; }
    public Nullable<DateTime> dtCreated { get; set; }
    public string strCreatedBy { get; set; }
    public Nullable<DateTime> dtModified { get; set; }
    public string strModifiedBy { get; set; }

    public virtual MemberType MemberType { get; set; }
    public virtual MerchantProduct MerchantProduct { get; set; }
}