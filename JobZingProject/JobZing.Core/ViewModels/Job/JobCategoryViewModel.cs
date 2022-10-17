using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Core.ViewModels.Job
{
    public class JobCategoryViewModel
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string DateTime { get; set; }
        public long? ParentID { get; set; }
        public string ParentName { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
    }
}
