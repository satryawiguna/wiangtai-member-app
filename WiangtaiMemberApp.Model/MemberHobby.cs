using System;

namespace WiangtaiMemberApp.Model;

public class MemberHobby
{
    public Guid MemberID { get; set; }
    public int idHobbies { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual Member Member { get; set; }
    public virtual Hobby Hobby { get; set; }

}