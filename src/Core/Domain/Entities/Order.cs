using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public Product Product { get; set; }
        public DateTime OrderDate { get; set; }
        public int Count { get; set; }
    }
}
