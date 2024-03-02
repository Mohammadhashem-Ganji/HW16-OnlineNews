using HW16.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HW16.EntitiesConfigoration
{
    public class Tbl_WorkflowConfigoration : IEntityTypeConfiguration<Tbl_Workeflow>
    {
        public void Configure(EntityTypeBuilder<Tbl_Workeflow> builder)
        {
            builder.HasKey(x => x.Id);


            //throw new NotImplementedException();
        }
    }
}
