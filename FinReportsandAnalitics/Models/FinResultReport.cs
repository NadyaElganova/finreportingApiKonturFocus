using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.Models
{
    public class FinResultReport
    {

        public int ID { get; set; }
        public string Company { get; set; }
        public DateTime DateOfBalanse { get; set; }

        public long _2110 { get; set; }
        public long _2120 { get; set; }
        public long _2100 { get; set; }
        public long _2210 { get; set; }
        public long _2220 { get; set; }
        public long _2200 { get; set; }
        public long _2310 { get; set; }
        public long _2320 { get; set; }
        public long _2330 { get; set; }
        public long _2340 { get; set; }
        public long _2350 { get; set; }
        public long _2300 { get; set; }
        public long _2410 { get; set; }
        public long _2411 { get; set; }
        public long _2412 { get; set; }
        public long _2430 { get; set; }

        public long _2421 { get; set; }
        public long _2460 { get; set; }
        public long _2450 { get; set; }
        public long _2400 { get; set; }


        public ObservableCollection<FinResultReport> BuildFinResultReport(List<OrganizationData> organizationDatas)
        {
            ObservableCollection<FinResultReport> CurrentReports = new ObservableCollection<FinResultReport>();
           
            int count = 0;
            int value = organizationDatas[0].BuhForms.Count();

            while (count != value)
            {
                count++;
                FinResultReport FRLast = new FinResultReport();
                FRLast.Company = "Тестовая";
                              
                FRLast.DateOfBalanse = new DateTime(organizationDatas[0].BuhForms[value - count].Year, 12, 31);

                foreach (Row row in organizationDatas[0].BuhForms[value - count].Form2)
                {


                    switch (row.Code)
                    {
                        case 2110:
                            FRLast._2110 = row.EndValue;
                            break;


                        case 2120:
                            FRLast._2120 = row.EndValue;
                            break;

                        case 2100:
                            FRLast._2100 = row.EndValue;
                            break;

                        case 2210:
                            FRLast._2210 = row.EndValue;
                            break;

                        case 2220:
                            FRLast._2220 = row.EndValue;
                            break;

                        case 2200:
                            FRLast._2200 = row.EndValue;
                            break;

                        case 2310:
                            FRLast._2310 = row.EndValue;
                            break;

                        case 2320:
                            FRLast._2320 = row.EndValue;
                            break;

                        case 2330:
                            FRLast._2330 = row.EndValue;
                            break;

                        case 2340:
                            FRLast._2340 = row.EndValue;
                            break;

                        case 2350:
                            FRLast._2350 = row.EndValue;
                            break;

                        case 2300:
                            FRLast._2300 = row.EndValue;
                            break;

                        case 2410:
                            FRLast._2410 = row.EndValue;
                            break;

                        case 2411:
                            FRLast._2411 = row.EndValue;
                            break;

                        case 2421:
                            FRLast._2421 = row.EndValue;
                            break;

                        case 2412:
                            FRLast._2412 = row.EndValue;
                            break;

                        case 2460:
                            FRLast._2460 = row.EndValue;
                            break;

                        case 2430:
                            FRLast._2430 = row.EndValue;
                            break;

                        case 2400:
                            FRLast._2400 = row.EndValue;
                            break;

                        case 2450:
                            FRLast._2450 = row.EndValue;
                            break;

                    }

                }

                CurrentReports.Add(FRLast);

            }  
           
            return CurrentReports;
        }
    }
}
