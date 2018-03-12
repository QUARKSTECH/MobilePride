using System;
using System.Collections.Generic;

namespace MobilePride.Entity
{
    /// <summary>
    /// RockRiver Role
    /// </summary>
    public class Role : IEntityBase
    {
        public Role()
        {
            this.UserRoles = new HashSet<UserRole>();
        }

        public Guid ID { get; set; }
        public long KeyID { get; set; }
        public string Name { get; set; } 

        //Relationship
        public virtual ICollection<UserRole> UserRoles { get; set; }

        //common columns
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? CreatedDateUnix { get; set; }
        public long? ModifiedDateUnix { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
