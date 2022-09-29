using System;

namespace WiangtaiMemberApp.Model;

public class Hobby
{
    public int idHobbies { get; set; }
    public string strName { get; set; }

    public virtual ICollection<MemberHobby> MemberHobbies { get; set; }
}