using System;

namespace MobilePride.Entity
{
    /// <summary>
    /// RockRiver User's Role
    /// </summary>
    public class UserRole : IEntityBase
    {
        public Guid ID { get; set; }
        public long KeyID { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; } 

        //Relationship
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }

        //common columns
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? CreatedDateUnix { get; set; }
        public long? ModifiedDateUnix { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
