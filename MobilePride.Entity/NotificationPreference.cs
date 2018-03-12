using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePride.Entity
{
    public class NotificationPreference : IEntityBase
    {
        public Guid ID { get; set; }
        public long KeyID { get; set; }
        public Guid UserId { get; set; }
        public Guid NotificationTypeId { get; set; }
        public bool IsNotifiedByEmail { get; set; }
        public bool IsNotifiedByPushNotification { get; set; }
        public bool IsNotifiedBySMS { get; set; }

        //Relationship
        public virtual User User { get; set; }
        public virtual NotificationType NotificationType { get; set; }

        //common columns
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? CreatedDateUnix { get; set; }
        public long? ModifiedDateUnix { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
