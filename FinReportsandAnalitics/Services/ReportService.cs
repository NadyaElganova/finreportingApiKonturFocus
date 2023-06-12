using FinReportsandAnalitics.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinReportsandAnalitics.Services
{
    public class ReportService
    {
        public async Task<ObservableCollection<OrganizationData>> GetRequestBuhFormsAsync(string innOgrn)
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
                var queryString = $"?inn=6663003127&key=3208d29d15c507395db770d0e65f3711e40374df";
                var fullUrl = $"{url}{queryString}";

                var response = await httpClient.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    using (StreamWriter writer = new StreamWriter("example_1.txt"))
                    {
                        writer.Write(responseContent.ToString());
                    }
                    var myDeserializedClass = JsonConvert.DeserializeObject<ObservableCollection<OrganizationData>>(responseContent);

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
