using System;
namespace WiangtaiMemberApp.Model;

public class Tax
{
    public Guid TaxID { get; set; }
    public string TaxCode { get; set; }
    public decimal TaxValue { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}