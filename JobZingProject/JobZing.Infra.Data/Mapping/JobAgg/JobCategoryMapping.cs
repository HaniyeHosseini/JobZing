using JobZing.Domain.Models.JobAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Infra.Data.Mapping.JobAgg
{
    public class JobCategoryMapping : IEntityTypeConfiguration<JobCategory>
    {
        public void Configure(EntityTypeBuilder<JobCategory> builder)
        {
            builder.ToTable("JobCategory");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();
            builder.HasOne(x => x.Parent).WithMany().HasForeignKey(x => x.ID == x.ParentID);
        }
    }
}
