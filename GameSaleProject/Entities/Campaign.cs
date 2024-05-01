using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Entities
{
    public class Campaign : BaseEntity
    {
        public string Name { get; set; }
        public decimal Discount { get; set; }
    }
}
