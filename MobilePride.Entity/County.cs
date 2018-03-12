using System;
using System.Collections.Generic;

namespace MobilePride.Entity
{ 
    public class County : IEntityBase
    {
        public County()
        {
            States = new HashSet<State>(); 
        } 
        public Guid ID { get; set; }
        public long KeyID { get; set; }
        public string CountyName { get; set; } 
        public string Lat { get; set; } 
        public string Lng { get; set; } 
        public bool? Status { get; set; }

        //relationship
        public virtual ICollection<State> States { get; set; } 

        //common columns
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? CreatedDateUnix { get; set; }
        public long? ModifiedDateUnix { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}