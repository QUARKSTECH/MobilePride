using MobilePride.Entity;

namespace MobilePride.Data.Configurations
{
    public class UserConfiguration : EntityBaseConfiguration<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfiguration"/> class.
        /// </summary>
        public UserConfiguration()
        {
            Property(x => x.ID).HasColumnName(@"ID").IsRequired()  ;
            Property(x => x.Username).HasColumnName(@"Username").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Email).HasColumnName(@"Email").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.HashedPassword).HasColumnName(@"HashedPassword").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Salt).HasColumnName(@"Salt").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.IsLocked).HasColumnName(@"IsLocked").IsRequired().HasColumnType("bit"); 
        }
    }
}
