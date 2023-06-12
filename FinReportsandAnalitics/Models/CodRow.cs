using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.Models
{
    public class CodRow
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public long StartValue { get; set; }
        public long EndValue { get; set; }
    }
}
