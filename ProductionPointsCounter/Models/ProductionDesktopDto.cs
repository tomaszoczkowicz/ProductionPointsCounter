using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionPointsCounterAPI.Models
{
    public class ProductionDesktopDto
    {
        public IEnumerable<OrdersDto>? OrderList { get; set; }
        public double? PlannedPoints { get; set; }
        public double? CompletedPoints { get; set; }

    }
}
