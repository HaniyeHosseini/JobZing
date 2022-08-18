using JobZing.Domain.Models.JobAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Infra.Data.Context
{
    public class JobZingContext : DbContext
    {
        public DbSet<JobCategory> JobCategories { get; set; }
        public JobZingContext(DbContextOptions<JobZingContext> options):base(options)
        {
        }
    }
}
