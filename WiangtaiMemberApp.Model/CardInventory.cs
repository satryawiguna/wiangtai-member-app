using System;
namespace WiangtaiMemberApp.Model;

public class CardInventory
{
    public Guid idCardInventory { get; set; }
    public Guid idMemberType { get; set; }
    public string strBoxNo { get; set; }
    public string strGRNNo { get; set; }
    public string strCardInventoryFile { get; set; }
    public Nullable<int> intNoRecords { get; set; }
    public string strEnrollmentFile { get; set; }
    public Nullable<int> intEnrollNoRecords { get; set; }
    public Nullable<int> intStatus { get; set; }
    public Nullable<Guid> idCreatedBy { get; set; }
    public Nullable<DateTime> dtCreatedDate { get; set; }
    public Nullable<Guid> idModifiedBy { get; set; }
    public Nullable<DateTime> dtModifiedDate { get; set; }

    public virtual MemberType MemberType { get; set; }
}

