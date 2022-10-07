using System;
namespace WiangtaiMemberApp.Model;

public class ReferenceType
{
    public Guid idReferenceType { get; set; }
    public int? ReferenceTypeCode { get; set; }
    public string ReferenceTypeName { get; set; }
    public string ReferenceTypeLable { get; set; }
    public string TextboxMask { get; set; }
    public string Validation { get; set; }
    public bool? isVisible { get; set; }
    public int? intSort { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? ModifiedBy { get; set; }
}