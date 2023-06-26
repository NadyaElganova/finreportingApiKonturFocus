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
using Azure;
using System.Net.Sockets;
using Newtonsoft.Json.Linq;

namespace FinReportsandAnalitics.Services
{
    public class KonturSendReciever
    {


        List<OrganizationData> DeserializedClass = new List<OrganizationData>();

        // медот который запрашивает данные.

        public static async Task<List<OrganizationData>> GetRequestBuhFormsAsync(string key, string innOgrn = "6663003127")
        {
            if (string.IsNullOrEmpty(innOgrn))
            {
                MessageBox.Show("Введите ИНН/ОГРН");
                return null;
            }
            string tmp;
            if (innOgrn.Count() == 13)
            {
                tmp = $"ogrn={innOgrn}";
            }
            else if (innOgrn.Count() == 10)
            {
                tmp = $"inn={innOgrn}";
            }
            else
            {
                MessageBox.Show("Введите корректный ИНН/ОГРН");
                return null;
            }
            using (var httpClient = new HttpClient())
            {
                var url = "https://focus-api.kontur.ru/api3/buh";
                // var queryString = $"?inn=6663003127&key=3208d29d15c507395db770d0e65f3711e40374df";

                var queryString = $"?{tmp}&key={key}";

                var fullUrl = $"{url}{queryString}";
                HttpResponseMessage response = new HttpResponseMessage();
                try
                {
                    response = await httpClient.GetAsync(fullUrl);
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Ошибка HTTP запроса: {ex.Message}. Проверьте подключение к интернету!");
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка : {ex.Message}");
                    return null;
                }
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    using (StreamWriter writer = new StreamWriter("example_1.txt"))
                    {
                        writer.Write(responseContent.ToString());
                    }
                    //    System.Windows.MessageBox.Show(responseContent.ToString());

                    List<OrganizationData> myDeserializedClass = JsonConvert.DeserializeObject<List<OrganizationData>>(responseContent);
                    if (myDeserializedClass.Count == 0)
                    {
                        MessageBox.Show("Проверьте правильность ввода ИНН/ОГРН!");
                        return null;
                    }
                    else
                    {
                        return myDeserializedClass;
                    }
                }
                else
                {
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}");

                }
            }
        }

        public static async Task<CompanyNames> GetRequestCompanyNameAsync(string key, string innOgrn = "6663003127")
        {
            string tmp;
            if (innOgrn.Count() == 13)
            {
                tmp = $"ogrn={innOgrn}";
            }
            else if (innOgrn.Count() == 10)
            {
                tmp = $"inn={innOgrn}";
            }
            else
            {
                return null;
            }
            using (var httpClient = new HttpClient())
            {
                var url = "https://focus-api.kontur.ru/api3/req";
                // var queryString = $"?inn=6663003127&key=3208d29d15c507395db770d0e65f3711e40374df";

                var queryString = $"?{tmp}&key={key}";

                var fullUrl = $"{url}{queryString}";
                HttpResponseMessage response = new HttpResponseMessage();

                response = await httpClient.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    using (StreamWriter writer = new StreamWriter("example_1.txt"))
                    {
                        writer.Write(responseContent.ToString());
                    }
                    //    System.Windows.MessageBox.Show(responseContent.ToString());

                    JArray Ja = JArray.Parse(responseContent);
                    return new CompanyNames()
                    {
                        ShortName = (string)Ja.SelectToken("[0].UL.legalName.short"),
                        FullName = (string)Ja.SelectToken("[0].UL.legalName.full")
                    };

                }
                else
                {
                    throw new HttpRequestException($"Request failed with status code {response.StatusCode}");

                }
            }
        }
    }
}

