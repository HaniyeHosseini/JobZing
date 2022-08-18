using JobZing.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Domain.Models.JobAgg
{
    public class JobCategory : BaseEntity
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string Slug { get; set; }
        public long ParentID { get; set; }
    }
}
