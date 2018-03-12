using System;
using System.Collections.Generic;

namespace MobilePride.Entity
{
    public class State : IEntityBase
    {
        
        public Guid ID { get; set; }
        public long KeyID { get; set; }
        public float CountryId { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public bool Status { get; set; } 

        //Relationship
        public virtual County County { get; set; }
       
        //common columns
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? CreatedDateUnix { get; set; }
        public long? ModifiedDateUnix { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
