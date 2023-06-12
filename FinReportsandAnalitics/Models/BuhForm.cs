using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.Models
{
    public class BuhForm
    {
        public int Year { get; set; }
        public string OrganizationType { get; set; }
        public ObservableCollection<CodRow> Form1 { get; set; }
        public ObservableCollection<CodRow> Form2 { get; set; }
    }
}
