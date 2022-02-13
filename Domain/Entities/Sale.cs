using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Sale
    {
        public DateTime Date { get; set; }
        public int? EmployeeID { get; set; }
        public double PricePerUnit { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int SalesID { get; set; }
    }
}
