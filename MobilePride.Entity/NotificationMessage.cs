using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePride.Entity
{
    public class NotificationMessage : IEntityBase
    {
        public Guid ID { get; set; }
        public long KeyID { get; set; }
        public Guid? NotificationTypeId { get; set; }
        public Guid? FromUserId { get; set; }
        public Guid? ToUserId { get; set; }
        public Guid? PostMessageId { get; set; }
        public Guid? PostLikeMapperId { get; set; }
        public Guid? PostCommentMapperId { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public string MessageFormatEng { get; set; }
        public string MessageFormatJpn { get; set; }

        //Relationship
        public virtual NotificationType NotificationType { get; set; }
        public virtual User ToUser { get; set; }
        public virtual User FromUser { get; set; }
      

        //common columns
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? CreatedDateUnix { get; set; }
        public long? ModifiedDateUnix { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
