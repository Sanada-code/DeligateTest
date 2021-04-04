using System;
using System.Net.Http;

class Program05
{
    static void main(string[] args)
    {
        HttpRequest("http://www.google/", GetStatusCode);

        Console.ReadLine();
    }

    static void GetStatusCode(HttpResponseMessage res)
    {
        Console.WriteLine(res.StatusCode.ToString());
    }

    async static void HttpRequest(String url, Action<HttpResponseMessage> callback) 
    {
        using (HttpClient httpClient = new HttpClient())
        {
            HttpResponseMessage res = await httpClient.GetAsync(url);
            callback(res);
        }
    }
}


