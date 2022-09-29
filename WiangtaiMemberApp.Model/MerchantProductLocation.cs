using System;
namespace WiangtaiMemberApp.Model;

public class MerchantProductLocation
{
    public Guid idMerchantProduct { get; set; }
    public long idMerchantLocation { get; set; }
    public Guid idMerchant { get; set; }
    public string strCreateBy { get; set; }
    public Nullable<DateTime> dtCreate { get; set; }
    public string strModifiedBy { get; set; }
    public Nullable<DateTime> dtModified { get; set; }

    public virtual MerchantProduct MerchantProduct { get; set; }
}
