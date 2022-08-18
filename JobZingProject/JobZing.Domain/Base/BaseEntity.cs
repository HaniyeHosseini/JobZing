using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobZing.Domain.Base
{
    public class BaseEntity
    {
        public long ID { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
