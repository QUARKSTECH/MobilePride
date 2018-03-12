using MobilePride.Entity;

namespace MobilePride.Data.Configurations
{
    public class GlobalVariableConfiguration : EntityBaseConfiguration<GlobalVariable>
    {
        public GlobalVariableConfiguration()
        {
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Value).HasColumnName(@"Value").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
        }
    }
}
