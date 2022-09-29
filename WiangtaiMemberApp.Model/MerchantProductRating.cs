using System;

namespace WiangtaiMemberApp.Model;

public class MerchantProductRating
{
    public Guid idMerchantProduct { get; set; }
    public Nullable<Guid> idMember { get; set; }
    public byte intRate { get; set; }
    public string strReview { get; set; }
    public System.DateTime dtCreated { get; set; }
    public string strCreatedBy { get; set; }
    public System.DateTime dtModified { get; set; }
    public string strModifiedBy { get; set; }
    public Nullable<double> idMasterAccount { get; set; }
    public double idPortalCredential { get; set; }

    public virtual Member Member { get; set; }
    public virtual MerchantProduct MerchantProduct { get; set; }
}

