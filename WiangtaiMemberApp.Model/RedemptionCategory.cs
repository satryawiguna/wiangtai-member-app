using System;
namespace WiangtaiMemberApp.Model;

public class RedemptionCategory
{
    public Guid RedemptionCategoryID { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDesc { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<int> intSorting { get; set; }

    public virtual ICollection<RedemptionProduct> RedemptionProducts { get; set; }
}

