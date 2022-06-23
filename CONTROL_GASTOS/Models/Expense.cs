using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL_GASTOS.Models
{
    internal class Expense
    {
        public int Id { get; set; }

        public double Amount { get; set; }
        public int ConceptID { get; set; }
        public int CategoryID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
