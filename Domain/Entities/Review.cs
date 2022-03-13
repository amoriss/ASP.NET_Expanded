using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Review
    {
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public string Reviewer { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
