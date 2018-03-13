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

        public long RoleId { get; set; }
        public Guid KeyId { get; set; } = Guid.NewGuid();
        public string RoleName { get; set; } 

        //Relationship
        public virtual ICollection<UserRole> UserRoles { get; set; }

        //common columns
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? DeletedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
