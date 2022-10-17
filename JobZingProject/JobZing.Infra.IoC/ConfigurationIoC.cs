using JobZing.Core.Interfaces.Job;
using JobZing.Core.Services.Job;
using JobZing.Domain.Interfaces.Base;
using JobZing.Domain.Interfaces.Job;
using JobZing.Domain.Models.Base;
using JobZing.Infra.Data.Repository.Base;
using JobZing.Infra.Data.Repository.Job;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace JobZing.Infra.IoC
{
    public class ConfigurationIoC
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IBaseRepository<BaseEntity>, BaseRepository<BaseEntity>>();
            services.AddTransient<IJobCategoryRepository, JobCategoryRepository>();
            services.AddTransient<IJobCategoryService, JobCategoryService>();
        }
    }
}
