using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace Day21_restAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Employees> darbinieki = new List<Employees>();

            String url = "http://dummy.restapiexample.com/api/v1/employees";
            String json = GetReleases(url);
            var received = JsonConvert.DeserializeObject<Container>(json);

            foreach (var e in received.data)
            {
                Console.WriteLine(e.id + " " + e.employee_name + " " + e.employee_salary + " " + e.employee_age + " " + e.profile_image);
            }

            //Seit sanemtos datus saglabajam lista
            for(int i = 0; i < received.data.Count; i++)
            {
                darbinieki.Add(new Employees(received.data[i].id, received.data[i].employee_name, received.data[i].employee_salary, received.data[i].employee_age, received.data[i].profile_image));
            }

            //Sis ir tikai, lai parbauditu, vai dati lista vispar saglabajas
            foreach(var e in darbinieki)
            {
                Console.WriteLine(e.employee_name + " " + e.employee_salary);
            }*/
            Class1.test();
        }
        public static string GetReleases(string url)
        {
            WebClient client = new WebClient();

            String dati = client.DownloadString(url);

            return dati;
        }
    }
}
