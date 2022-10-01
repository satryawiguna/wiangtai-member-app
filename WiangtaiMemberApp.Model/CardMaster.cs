using System;
namespace WiangtaiMemberApp.Model;

public class CardMaster
{
    public Guid CardMasterID { get; set; }
    public Nullable<long> CardNumber { get; set; }
    public DateTime SalesDate { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string CardNumberEncrypted { get; set; }
    public string CardNumberShow { get; set; }
}
