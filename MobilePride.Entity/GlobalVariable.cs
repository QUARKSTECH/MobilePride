using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePride.Entity
{
    public class GlobalVariable :IEntityBase
    {
        public Guid ID { get; set; }
        public long KeyID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        //common columns
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? CreatedDateUnix { get; set; }
        public long? ModifiedDateUnix { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
