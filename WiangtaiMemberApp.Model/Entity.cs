using System;
namespace WiangtaiMemberApp.Model
{
    public class Entity
    {
        public Guid EntityID { get; set; }
        public Guid EntityTypeID { get; set; }
        public Nullable<System.Guid> EntityParentID { get; set; }
        public string EntityName { get; set; }
        public string EntityAddress { get; set; }
        public Nullable<Guid> EntityCountryID { get; set; }
        public Nullable<Guid> EntityStateID { get; set; }
        public Nullable<Guid> EntityCityID { get; set; }
        public string EntityPostcode { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string EntityCity { get; set; }

        public virtual ICollection<Entity> Entity1 { get; set; }
        public virtual Entity Entity2 { get; set; }
        public virtual EntityType EntityType { get; set; }
        public virtual Region Region { get; set; }
        public virtual Region Region1 { get; set; }
        public virtual Region Region2 { get; set; }
        public virtual ICollection<SecurityRoleEntity> SecurityRoleEntities { get; set; }
    }
}

