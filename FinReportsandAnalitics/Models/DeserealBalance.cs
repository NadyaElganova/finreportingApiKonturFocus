using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.Models
{
    public class Row
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public long StartValue { get; set; }
        public long EndValue { get; set; }
    }

    public class BuhForm
    {
        public int Year { get; set; }
        public string OrganizationType { get; set; }
        public List<Row> Form1 { get; set; }
        public List<Row> Form2 { get; set; }
    }

    public class OrganizationData
    {
        public string Inn { get; set; }
        public string Ogrn { get; set; }
        public string FocusHref { get; set; }
        public List<BuhForm> BuhForms { get; set; }

    }


}