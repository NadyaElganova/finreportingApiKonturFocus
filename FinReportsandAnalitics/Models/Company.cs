using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Inn { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; }



        public ICollection<BalanceRepot> balanceRepots { get; set; }
        public ICollection<FinResultReport> finResultReports { get; set; }  
 

    }
}
