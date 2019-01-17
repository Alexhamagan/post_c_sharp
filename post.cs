using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Specialized;
 
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://upread.ru/save.php";
            using (var webClient = new WebClient())
            {
                var pars = new NameValueCollection();
                pars.Add("fname", "текст сообщения");
                var response = webClient.UploadValues(url, pars);
                string str = System.Text.Encoding.UTF8.GetString(response);
                Console.WriteLine(str);
                Console.ReadKey();
            }
        }
    }
}
