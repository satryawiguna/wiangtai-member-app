using System;

namespace WiangtaiMemberApp.Model;

public class MerchantCategory
{
    public Guid MerchantCategoryID { get; set; }
    public Nullable<System.Guid> MerchantID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<byte> intCatgType { get; set; }
    public int Sort { get; set; }
    public Nullable<System.Guid> ParentID { get; set; }

    public virtual Merchant Merchant { get; set; }
}