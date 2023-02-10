using AdoNetWinformsApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdoNetWinformsApp.EntityMappings
{
    internal class SupplierEntityMap : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100);
        }
    }
}
