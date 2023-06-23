using FinReportsandAnalitics.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.Services
{
    public class AnaliticServise
    {

        public AnaliticServise() { }

        public string GetSimpleAnaliticalReport(ObservableCollection<FinResultReport> FinResultReports,
                                                ObservableCollection<BalanceRepot> BalanceReports)
        {
            string CurrentReport = "Короткий анализ показал, что:";

            long LastOwnWorkingCapital = BalanceReports[0]._1300 - BalanceReports[0]._1100;
            long PreLastOwnWorkingCapital = BalanceReports[1]._1300 - BalanceReports[1]._1100;

            if (LastOwnWorkingCapital < 0)
            { CurrentReport += $" компания утратила собственный оборотный капитал (={LastOwnWorkingCapital.ToString()}), что свидетельствует о полной зависимоcти от кредиторов"; }

            else if (LastOwnWorkingCapital > 0)
            { CurrentReport += $" компания обладает собственным капиталом (={(LastOwnWorkingCapital/100).ToString("N0")}) тыс. руб"; }

            else if (LastOwnWorkingCapital > (BalanceReports[0]._1210 + BalanceReports[0]._1230))
            { CurrentReport += " и оборотный капитал оптимально покрывает запасы и дебиторскую задолженность"; }

            if (FinResultReports[0]._2400 < 0)
            { CurrentReport += ", у компании формируется убыток"; }
            else
            {
                double a = FinResultReports[0]._2400 / 10000;
                double b = FinResultReports[1]._2400 / 10000;
                var LastProfitGrowRate = a / b;

                a = FinResultReports[0]._2110 / 10000;
                b = FinResultReports[1]._2110 / 10000;

                var LastRevenueGrowthRate = a / b;
                a = BalanceReports[0]._1700 / 10000;
                b = BalanceReports[1]._1700 / 10000;


                var LastBalanceSheetGrowthRate = a / b;

                if (LastProfitGrowRate > LastRevenueGrowthRate && LastRevenueGrowthRate > LastBalanceSheetGrowthRate)
                {
                    CurrentReport += ", компания соблюдает правило устойчивого развтия, эффективность деятельности растет " +
                                 "быстрее объемов производства и продажи";
                }

                else if (LastProfitGrowRate < LastRevenueGrowthRate && LastRevenueGrowthRate > LastBalanceSheetGrowthRate)
                {
                    CurrentReport += ", компании следует провышать эффективнсоть, так как объемы продаж растут быстрее чем прибыль";
                }

                else if (LastProfitGrowRate < LastRevenueGrowthRate && LastRevenueGrowthRate < LastBalanceSheetGrowthRate)
                {
                    CurrentReport += ",компания снижает эффективность, объемы баланса и выручки растут, но эффективность растет медленно";
                }

                else if (LastProfitGrowRate > LastRevenueGrowthRate && LastRevenueGrowthRate < LastBalanceSheetGrowthRate)
                {
                    CurrentReport += ",прибыль растет быстрее выручки, выручка расчет медленее баланса, затоваривание? или искать иные причины раздувания баланса";
                }

                else
                {
                    CurrentReport += $"----------ПРОВЕРИТЬ ДАННЫЕ, НЕ ПОПАЛ В СООТНОШЕНИЕ ЗОЛОТОГО ПРАВИЛА---------- ";
                       
                }



            }


            return CurrentReport;

        }

     

        public List<Dictionary<string, double>> GetBasicBalanceСoefficients(ObservableCollection<FinResultReport> FinResultReports,
                                             ObservableCollection<BalanceRepot> BalanceReports)
        {

            List<Dictionary<string, double>> Сoefficients = new List<Dictionary<string, double>>();


            // ниже считаем базовый год - потом переделать на цикл

            Dictionary<string, double> Сoefficients_Base = new Dictionary<string, double>();
            double a = BalanceReports[0]._1240 / 10000;
            double b = BalanceReports[0]._1250 / 10000;
            double c = BalanceReports[0]._1500 / 10000;
            double d;

            double TMP = (a + b) / c;
            Сoefficients_Base.Add("AbsoluteLiquidity", TMP);//абсолюная ликвидность

            a = BalanceReports[0]._1230 / 10000;
            b = BalanceReports[0]._1240 / 10000;
            c = BalanceReports[0]._1250 / 10000;
            d = BalanceReports[0]._1500 / 10000;
            TMP = (a + b + c) / d;
            Сoefficients_Base.Add("UrgentLiquidity", TMP); //срочная ликвидность

            a = BalanceReports[0]._1300 / 10000;
            b = BalanceReports[0]._1700 / 10000;
            TMP = a / b;
            Сoefficients_Base.Add("Autonomy", TMP); //автономия


            b = BalanceReports[0]._1150 / 10000;
            TMP = a / b;
            Сoefficients_Base.Add("CoefficientCoverageFixedAssetsOwnFunds", TMP); //коэффициент покрытия собственных основными
            Сoefficients.Add(Сoefficients_Base);


            ///   ниже считаем (базовый-1) год 
            Dictionary<string, double> Сoefficients_Base_minus_1 = new Dictionary<string, double>();
            a = BalanceReports[1]._1240 / 10000;
            b = BalanceReports[1]._1250 / 10000;
            c = BalanceReports[1]._1500 / 10000;


            TMP = (a + b) / c;
            Сoefficients_Base_minus_1.Add("AbsoluteLiquidity", TMP);//абсолюная ликвидность

            a = BalanceReports[1]._1230 / 10000;
            b = BalanceReports[1]._1240 / 10000;
            c = BalanceReports[1]._1250 / 10000;
            d = BalanceReports[1]._1500 / 10000;
            TMP = (a + b + c) / d;
            Сoefficients_Base_minus_1.Add("UrgentLiquidity", TMP); //срочная ликвидность

            a = BalanceReports[1]._1300 / 10000;
            b = BalanceReports[1]._1700 / 10000;
            TMP = a / b;
            Сoefficients_Base_minus_1.Add("Autonomy", TMP); //автономия


            b = BalanceReports[1]._1150 / 10000;
            TMP = a / b;
            Сoefficients_Base_minus_1.Add("CoefficientCoverageFixedAssetsOwnFunds", TMP); //коэффициент покрытия собственных основными
            Сoefficients.Add(Сoefficients_Base_minus_1);


            ///   ниже считаем (базовый-2) год 
            Dictionary<string, double> Сoefficients_Base_minus_2 = new Dictionary<string, double>();
            a = BalanceReports[2]._1240 / 10000;
            b = BalanceReports[2]._1250 / 10000;
            c = BalanceReports[2]._1500 / 10000;


            TMP = (a + b) / c;
            Сoefficients_Base_minus_2.Add("AbsoluteLiquidity", TMP);//абсолюная ликвидность

            a = BalanceReports[2]._1230 / 10000;
            b = BalanceReports[2]._1240 / 10000;
            c = BalanceReports[2]._1250 / 10000;
            d = BalanceReports[2]._1500 / 10000;
            TMP = (a + b + c) / d;
            Сoefficients_Base_minus_2.Add("UrgentLiquidity", TMP); //срочная ликвидность

            a = BalanceReports[2]._1300 / 10000;
            b = BalanceReports[2]._1700 / 10000;
            TMP = a / b;
            Сoefficients_Base_minus_2.Add("Autonomy", TMP); //автономия


            b = BalanceReports[2]._1150 / 10000;
            TMP = a / b;
            Сoefficients_Base_minus_2.Add("CoefficientCoverageFixedAssetsOwnFunds", TMP); //коэффициент покрытия собственных основными
            Сoefficients.Add(Сoefficients_Base_minus_2);


            return Сoefficients;
        }





    }
}
