using AdoNetWinformsApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoNetWinformsApp.EntityMappings
{
    public class GoodTypeEntityMap : IEntityTypeConfiguration<GoodType>
    {
        public void Configure(EntityTypeBuilder<GoodType> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100);
        }
    }
}
