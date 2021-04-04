using System;
using System.Net.Http;

class Program06
{
    static void Main(string[] args)
    {

        HttpRquest("http://www.google.com", (res) => {
            Console.WriteLine(res.StatusCode.ToString());
        });

        Console.ReadLine();
    }

    async static void HttpRquest(String url, Action<HttpResponseMessage> callback)
    {

        using (HttpClient httpClient = new HttpClient())
        {
            HttpResponseMessage res = await httpClient.GetAsync(url);
            callback(res);
        }
    }
}


