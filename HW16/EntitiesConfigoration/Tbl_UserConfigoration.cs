using HW16.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW16.EntitiesConfigoration
{
    public class Tbl_UserConfigoration : IEntityTypeConfiguration<Tbl_User>
    {
        public void Configure(EntityTypeBuilder<Tbl_User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            

            //throw new NotImplementedException();
        }
    }
}
