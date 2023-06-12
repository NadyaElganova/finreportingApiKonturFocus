using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.Models
{
    public class OrganizationData
    {
        public string Inn { get; set; }
        public string Ogrn { get; set; }
        public string FocusHref { get; set; }
        public ObservableCollection<BuhForm> BuhForms { get; set; }
    }
}
