using AdoNetWinformsApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoNetWinformsApp.EntityMappings
{
    public class GoodEntityMap : IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.HasOne(x => x.GoodType)
                .WithMany(x => x.Goods)
                .HasForeignKey(x => x.GoodsTypeId);
        }
    }
}
