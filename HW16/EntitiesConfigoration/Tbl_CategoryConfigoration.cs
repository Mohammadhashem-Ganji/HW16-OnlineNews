using HW16.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW16.EntitiesConfigoration
{
    public class Tbl_CategoryConfigoration : IEntityTypeConfiguration<Tbl_Category>
    {
        public void Configure(EntityTypeBuilder<Tbl_Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();
            //throw new NotImplementedException();
        }
    }
}
