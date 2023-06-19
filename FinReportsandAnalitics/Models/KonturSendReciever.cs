using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FinReportsandAnalitics.Models;
using FinReportsandAnalitics.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Windows;

namespace FinReportsandAnalitics.Services
{


    public class KonturSendReciever_
    {

        // private readonly AppDbContext _context;

        // DbContextOptions<AppDbContext> options;

        List<OrganizationData> DeserializedClass = new List<OrganizationData>();

        public KonturSendReciever_()
        {
            //    options = new DbContextOptions<AppDbContext>();
            // _context = new AppDbContext(context);
        }


        // медот который запрашивает данные.

        public static async Task<List<OrganizationData>> GetRequestBuhFormsAsync(string innOgrn = "6663003127")
        {
            string tmp;
            if (innOgrn.Count() > 12)
            {
                tmp = $"ogrn={innOgrn}";
            }
            else
            {
                tmp = $"inn={innOgrn}";
            }
            using (var httpClient = new HttpClient())
            {
                var url = "https://focus-api.kontur.ru/api3/buh";
                // var queryString = $"?inn=6663003127&key=3208d29d15c507395db770d0e65f3711e40374df";

                var queryString = $"?{tmp}&key=3208d29d15c507395db770d0e65f3711e40374df";

                var fullUrl = $"{url}{queryString}";

                var response = await httpClient.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    using (StreamWriter writer = new StreamWriter("example_1.txt"))
                    {
                        writer.Write(responseContent.ToString());
                    }
                    //    System.Windows.MessageBox.Show(responseContent.ToString());

                    List<OrganizationData> myDeserializedClass = JsonConvert.DeserializeObject<List<OrganizationData>>(responseContent);

                    return myDeserializedClass;
                }
                else
                {
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}");
                }
            }
        }
    }
}



















