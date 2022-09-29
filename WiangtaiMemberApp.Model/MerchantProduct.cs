using System;

namespace WiangtaiMemberApp.Model;

public class MerchantProduct
{
    public Guid MerchantProductID { get; set; }
    public Guid MerchantID { get; set; }
    public Guid MerchantCategoryID { get; set; }
    public string ProductName { get; set; }
    public string ProductDesc { get; set; }
    public Nullable<byte> Badge { get; set; }
    public Nullable<DateTime> StartDate { get; set; }
    public Nullable<DateTime> EndDate { get; set; }
    public bool FeaturedProduct { get; set; }
    public Nullable<Guid> MainImageID { get; set; }
    public Nullable<Guid> ThumbnailImageID { get; set; }
    public string GalleryImage { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<Guid> DocumentID { get; set; }
    public string TermsAndConditions { get; set; }
    public string FileToUpload { get; set; }
    public Nullable<short> Sorting { get; set; }
    public string strLongDesc { get; set; }
    public Nullable<decimal> decRating { get; set; }

    public virtual Merchant Merchant { get; set; }
    public virtual ICollection<MerchantProductMemberType> MerchantProductMemberTypes { get; set; }
    public virtual ICollection<MerchantProductLocation> MerchantProductLocations { get; set; }
    public virtual ICollection<MerchantProductRating> MerchantProductRatings { get; set; }
    public virtual ICollection<PendingMerchantProductMemberTypeRequest> PendingMerchantProductMemberTypeRequests { get; set; }
}