using MobilePride.Entity;

namespace MobilePride.Data.Configurations
{
    public class UserRoleConfiguration : EntityBaseConfiguration<UserRole>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleConfiguration"/> class.
        /// </summary>
        public UserRoleConfiguration()
        {
            Property(x => x.ID).HasColumnName(@"ID").IsRequired()  ;
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired() ;
            Property(x => x.RoleId).HasColumnName(@"RoleId").IsRequired() ;
        }
    }
}
