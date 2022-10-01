using System;
namespace WiangtaiMemberApp.Model
{
    public class RaceType
    {
        public Guid RaceTypeID { get; set; }
        public string RaceCode { get; set; }
        public string RaceName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}

