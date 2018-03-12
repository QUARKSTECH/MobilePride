using System;
using System.Collections.Generic;

namespace MobilePride.Entity
{
    /// <summary>
    /// RockRiver User Account
    /// </summary>
    public class User : IEntityBase
    {
        public User()
        {
            this.UserDetails = new HashSet<UserDetail>(); 
            this.UserRoles = new HashSet<UserRole>();
            this.ForgotPasswordLogs = new HashSet<ForgotPasswordLog>();
            this.NotificationMessageMaps = new HashSet<NotificationMessage>();
           
        }

        public Guid ID { get; set; }
        public long KeyID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public string Token { get; set; }
        public DateTime? TokenExpiryDate { get; set; }
        public bool IsLocked { get; set; }
        
        //Relationship
        public virtual ICollection<UserDetail> UserDetails { get; set; } 
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<ForgotPasswordLog> ForgotPasswordLogs { get; set; }
        public virtual ICollection<NotificationMessage> NotificationMessageMaps { get; set; }
        public virtual ICollection<NotificationPreference> NotificationPreferences { get; set; }
       

        //common columns
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? CreatedDateUnix { get; set; }
        public long? ModifiedDateUnix { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }

    }
}
