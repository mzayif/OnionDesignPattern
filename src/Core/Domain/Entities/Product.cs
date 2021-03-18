using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }

    }
}
