using JobZing.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Domain.Models.JobAgg
{
    public class JobCategory : BaseEntity
    {
        public JobCategory(string title, bool isActive, string slug, string picture, string pictureAlt, string pictureTitle, long? parentID)
        {
            Title = title;
            IsActive = isActive;
            Slug = slug;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ParentID = parentID;
        }

        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string Slug { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public long? ParentID { get; set; }
        public virtual JobCategory Parent { get; set; }
    }
}
