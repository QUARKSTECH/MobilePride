using MobilePride.Entity;

namespace MobilePride.Data.Configurations
{
    /// <summary>
    /// Class CountyConfiguration.
    /// </summary>
    public class CountyConfiguration : EntityBaseConfiguration<County>
    {
        public CountyConfiguration()
        {
            Property(x => x.KeyID).HasColumnName(@"KeyID");
            Property(x => x.CountyName).HasColumnName(@"CountyName").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Lat).HasColumnName(@"Lat").IsOptional();
            Property(x => x.Lng).HasColumnName(@"Lng").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").IsOptional().HasColumnType("bit");
        }
    }
}
