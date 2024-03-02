using HW16.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW16.Views
{
    public class Tbl_ArticleConfigoration : IEntityTypeConfiguration<Tbl_Article>
    {
        public void Configure(EntityTypeBuilder<Tbl_Article> builder)
        {
            builder.Property(b => b.Title).HasMaxLength(40).IsRequired();
            builder.HasKey(b => b.Id);
            builder.Property(x => x.image).IsRequired();
            builder.HasOne(d => d.Category).WithMany(p => p.Articles)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Article_Categories");
           
            builder.HasOne(d => d.Workeflow).WithMany(p => p.Articles)
                 .HasForeignKey(d => d.WorkflowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Article_Workflows");
            //.HasForeignKey(d => d.CategoryId)
            //.OnDelete(DeleteBehavior.ClientSetNull)
            //.HasConstraintName("FK_Products_Categories");

            //throw new NotImplementedException();
        }
    }
}
