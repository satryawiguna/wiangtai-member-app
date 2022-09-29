using System;
namespace WiangtaiMemberApp.Model
{
    public class EntityType
    {
        public Guid EntityTypeID { get; set; }
        public string EntityType1 { get; set; }
        public Nullable<byte> EntityLevel { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
    }
}

