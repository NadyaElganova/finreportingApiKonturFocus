using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.Models
{
    public class BalanceRepot
    {
        public int ID { get; set; } 
        public string Company { get; set; }    
        public DateTime DateOfBalanse { get; set; }

        public long _1110 {get; set;}
        public long _1120 { get; set; }
        public long _1130 { get; set; }
        public long _1140 { get; set; }
        public long _1150 { get; set; }
        public long _1160 { get; set; }
        public long _1170 { get; set; }
        public long _1180 { get; set; }
        public long _1190 { get; set; }
        public long _1100 { get; set; }
        public long _1210 { get; set; }
        public long _1220 { get; set; }
        public long _1230 { get; set; }
        public long _1240 { get; set; }
        public long _1250 { get; set; }
        public long _1260 { get; set; }
        public long _1200 { get; set; }
        public long _1600 { get; set; }
        public long _1310 { get; set; }
        public long _1320 { get; set; }
        public long _1340 { get; set; }
        public long _1350 { get; set; }
        public long _1360 { get; set; }
        public long _1370 { get; set; }
        public long _1300 { get; set; }
        public long _1410 { get; set; }
        public long _1420 { get; set; }
        public long _1430 { get; set; }
        public long _1450 { get; set; }
        public long _1400 { get; set; }
        public long _1510 { get; set; }
        public long _1520 { get; set; }
        public long _1530 { get; set; }
        public long _1540 { get; set; }
        public long _1550 { get; set; }
        public long _1500 { get; set; }
        public long _1700 { get; set; }

        public ObservableCollection<BalanceRepot> BuildBalanse(List<OrganizationData> organizationDatas)
        {
            ObservableCollection<BalanceRepot> CurrentReports = new ObservableCollection<BalanceRepot>();

            BalanceRepot BRLast = new BalanceRepot();
            BRLast.Company = "Тестовая";

            int count = organizationDatas[0].BuhForms.Count;

            BRLast.DateOfBalanse = new DateTime(organizationDatas[0].BuhForms[count - 1].Year, 12, 31);

            foreach (Row row in organizationDatas[0].BuhForms[count - 1].Form1)
            {


                switch (row.Code)
                {
                    case 1110:
                        BRLast._1110 = row.EndValue;
                        break;
                    case 1120:
                        BRLast._1120 = row.EndValue;
                        break;
                    case 1130:
                        BRLast._1130 = row.EndValue;
                        break;
                    case 1140:
                        BRLast._1140 = row.EndValue;
                        break;
                    case 1150:
                        BRLast._1150 = row.EndValue;
                        break;
                    case 1160:
                        BRLast._1160 = row.EndValue;
                        break;
                    case 1170:
                        BRLast._1170 = row.EndValue;
                        break;
                    case 1180:
                        BRLast._1180 = row.EndValue;
                        break;
                    case 1190:
                        BRLast._1190 = row.EndValue;
                        break;
                    case 1100:
                        BRLast._1100 = row.EndValue;
                        break;
                    case 1210:
                        BRLast._1210 = row.EndValue;
                        break;
                    case 1220:
                        BRLast._1220 = row.EndValue;
                        break;
                    case 1230:
                        BRLast._1230 = row.EndValue;
                        break;
                    case 1240:
                        BRLast._1240 = row.EndValue;
                        break;
                    case 1250:
                        BRLast._1250 = row.EndValue;
                        break;
                    case 1260:
                        BRLast._1260 = row.EndValue;
                        break;
                    case 1200:
                        BRLast._1200 = row.EndValue;
                        break;
                    case 1600:
                        BRLast._1600 = row.EndValue;
                        break;
                    case 1310:
                        BRLast._1310 = row.EndValue;
                        break;
                    case 1320:
                        BRLast._1320 = row.EndValue;
                        break;
                    case 1340:
                        BRLast._1340 = row.EndValue;
                        break;
                    case 1350:
                        BRLast._1350 = row.EndValue;
                        break;
                    case 1360:
                        BRLast._1360 = row.EndValue;
                        break;
                    case 1370:
                        BRLast._1370 = row.EndValue;
                        break;
                    case 1300:
                        BRLast._1300 = row.EndValue;
                        break;
                    case 1410:
                        BRLast._1410 = row.EndValue;
                        break;
                    case 1420:
                        BRLast._1420 = row.EndValue;
                        break;
                    case 1430:
                        BRLast._1430 = row.EndValue;
                        break;
                    case 1450:
                        BRLast._1450 = row.EndValue;
                        break;
                    case 1400:
                        BRLast._1400 = row.EndValue;
                        break;
                    case 1510:
                        BRLast._1510 = row.EndValue;
                        break;
                    case 1520:
                        BRLast._1520 = row.EndValue;
                        break;
                    case 1530:
                        BRLast._1530 = row.EndValue;
                        break;
                    case 1540:
                        BRLast._1540 = row.EndValue;
                        break;
                    case 1550:
                        BRLast._1550 = row.EndValue;
                        break;
                    case 1500:
                        BRLast._1500 = row.EndValue;
                        break;
                    case 1700:
                        BRLast._1700 = row.EndValue;
                        break;
                }
            }
            CurrentReports.Add(BRLast);

            BalanceRepot BrPreLast = new BalanceRepot();

            Company = "Тестовая";

            BrPreLast.DateOfBalanse = new DateTime(organizationDatas[0].BuhForms[count - 2].Year, 12, 31);

            foreach (Row row in organizationDatas[0].BuhForms[count - 2].Form1)
            {


                switch (row.Code)
                {
                    case 1110:
                        BrPreLast._1110 = row.EndValue;
                        break;
                    case 1120:
                        BrPreLast._1120 = row.EndValue;
                        break;
                    case 1130:
                        BrPreLast._1130 = row.EndValue;
                        break;
                    case 1140:
                        BrPreLast._1140 = row.EndValue;
                        break;
                    case 1150:
                        BrPreLast._1150 = row.EndValue;
                        break;
                    case 1160:
                        BrPreLast._1160 = row.EndValue;
                        break;
                    case 1170:
                        BrPreLast._1170 = row.EndValue;
                        break;
                    case 1180:
                        BrPreLast._1180 = row.EndValue;
                        break;
                    case 1190:
                        BrPreLast._1190 = row.EndValue;
                        break;
                    case 1100:
                        BrPreLast._1100 = row.EndValue;
                        break;
                    case 1210:
                        BrPreLast._1210 = row.EndValue;
                        break;
                    case 1220:
                        BrPreLast._1220 = row.EndValue;
                        break;
                    case 1230:
                        BrPreLast._1230 = row.EndValue;
                        break;
                    case 1240:
                        BrPreLast._1240 = row.EndValue;
                        break;
                    case 1250:
                        BrPreLast._1250 = row.EndValue;
                        break;
                    case 1260:
                        BrPreLast._1260 = row.EndValue;
                        break;
                    case 1200:
                        BrPreLast._1200 = row.EndValue;
                        break;
                    case 1600:
                        BrPreLast._1600 = row.EndValue;
                        break;
                    case 1310:
                        BrPreLast._1310 = row.EndValue;
                        break;
                    case 1320:
                        BrPreLast._1320 = row.EndValue;
                        break;
                    case 1340:
                        BrPreLast._1340 = row.EndValue;
                        break;
                    case 1350:
                        BrPreLast._1350 = row.EndValue;
                        break;
                    case 1360:
                        BrPreLast._1360 = row.EndValue;
                        break;
                    case 1370:
                        BrPreLast._1370 = row.EndValue;
                        break;
                    case 1300:
                        BrPreLast._1300 = row.EndValue;
                        break;
                    case 1410:
                        BrPreLast._1410 = row.EndValue;
                        break;
                    case 1420:
                        BrPreLast._1420 = row.EndValue;
                        break;
                    case 1430:
                        BrPreLast._1430 = row.EndValue;
                        break;
                    case 1450:
                        BrPreLast._1450 = row.EndValue;
                        break;
                    case 1400:
                        BrPreLast._1400 = row.EndValue;
                        break;
                    case 1510:
                        BrPreLast._1510 = row.EndValue;
                        break;
                    case 1520:
                        BrPreLast._1520 = row.EndValue;
                        break;
                    case 1530:
                        BrPreLast._1530 = row.EndValue;
                        break;
                    case 1540:
                        BrPreLast._1540 = row.EndValue;
                        break;
                    case 1550:
                        BrPreLast._1550 = row.EndValue;
                        break;
                    case 1500:
                        BrPreLast._1500 = row.EndValue;
                        break;
                    case 1700:
                        BrPreLast._1700 = row.EndValue;
                        break;
                }
            }

            CurrentReports.Add(BrPreLast);

            BalanceRepot BrPrePreLast = new BalanceRepot();

            BrPrePreLast.DateOfBalanse = new DateTime(organizationDatas[0].BuhForms[count - 3].Year, 12, 31);

            foreach (Row row in organizationDatas[0].BuhForms[count - 3].Form1)
            {


                switch (row.Code)
                {
                    case 1110:
                        BrPrePreLast._1110 = row.EndValue;
                        break;
                    case 1120:
                        BrPrePreLast._1120 = row.EndValue;
                        break;
                    case 1130:
                        BrPrePreLast._1130 = row.EndValue;
                        break;
                    case 1140:
                        BrPrePreLast._1140 = row.EndValue;
                        break;
                    case 1150:
                        BrPrePreLast._1150 = row.EndValue;
                        break;
                    case 1160:
                        BrPrePreLast._1160 = row.EndValue;
                        break;
                    case 1170:
                        BrPrePreLast._1170 = row.EndValue;
                        break;
                    case 1180:
                        BrPrePreLast._1180 = row.EndValue;
                        break;
                    case 1190:
                        BrPrePreLast._1190 = row.EndValue;
                        break;
                    case 1100:
                        BrPrePreLast._1100 = row.EndValue;
                        break;
                    case 1210:
                        BrPrePreLast._1210 = row.EndValue;
                        break;
                    case 1220:
                        BrPrePreLast._1220 = row.EndValue;
                        break;
                    case 1230:
                        BrPrePreLast._1230 = row.EndValue;
                        break;
                    case 1240:
                        BrPrePreLast._1240 = row.EndValue;
                        break;
                    case 1250:
                        BrPrePreLast._1250 = row.EndValue;
                        break;
                    case 1260:
                        BrPrePreLast._1260 = row.EndValue;
                        break;
                    case 1200:
                        BrPrePreLast._1200 = row.EndValue;
                        break;
                    case 1600:
                        BrPrePreLast._1600 = row.EndValue;
                        break;
                    case 1310:
                        BrPrePreLast._1310 = row.EndValue;
                        break;
                    case 1320:
                        BrPrePreLast._1320 = row.EndValue;
                        break;
                    case 1340:
                        BrPrePreLast._1340 = row.EndValue;
                        break;
                    case 1350:
                        BrPrePreLast._1350 = row.EndValue;
                        break;
                    case 1360:
                        BrPrePreLast._1360 = row.EndValue;
                        break;
                    case 1370:
                        BrPrePreLast._1370 = row.EndValue;
                        break;
                    case 1300:
                        BrPrePreLast._1300 = row.EndValue;
                        break;
                    case 1410:
                        BrPrePreLast._1410 = row.EndValue;
                        break;
                    case 1420:
                        BrPrePreLast._1420 = row.EndValue;
                        break;
                    case 1430:
                        BrPrePreLast._1430 = row.EndValue;
                        break;
                    case 1450:
                        BrPrePreLast._1450 = row.EndValue;
                        break;
                    case 1400:
                        BrPrePreLast._1400 = row.EndValue;
                        break;
                    case 1510:
                        BrPrePreLast._1510 = row.EndValue;
                        break;
                    case 1520:
                        BrPrePreLast._1520 = row.EndValue;
                        break;
                    case 1530:
                        BrPrePreLast._1530 = row.EndValue;
                        break;
                    case 1540:
                        BrPrePreLast._1540 = row.EndValue;
                        break;
                    case 1550:
                        BrPrePreLast._1550 = row.EndValue;
                        break;
                    case 1500:
                        BrPrePreLast._1500 = row.EndValue;
                        break;
                    case 1700:
                        BrPrePreLast._1700 = row.EndValue;
                        break;
                }
            }

            CurrentReports.Add(BrPrePreLast);

            return CurrentReports;

        }

    }

   
}
