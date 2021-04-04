using System;
using System.Net.Http;

class Program04
{
    // delegate型を宣言
    public delegate void Callback(HttpResponseMessage res); // (1)

    static void ain(string[] args)
    {
        // (1)で定義したCallback型のDelegateである変数callbackを定義します
        // 変数callbackには、(2)で定義した関数GetStatusCodeを代入します。
        Callback callback = GetStatusCode;

        // (3)で定義した関数を呼び出しています。第1引数に指定したURLアクセスに
        // 対するHTTPレスポンスを、第2引数に指定したコールバック関数で処理します。
        HttpRequest("http://www.yahoo.co.jp/", callback);

        Console.ReadLine();
    }

    // HTTPレスポンスを処理するためのコールバック関数です。
    // ここでは、HTTPレスポンスのステータスコードを標準出力に出力してます。 
    static void GetStatusCode(HttpResponseMessage res) // (2)
    {
        Console.WriteLine(res.StatusCode.ToString());
    }

    // この関数は、第1引数に指定したURLにアクセスした際のHTTPレスポンスに対して、
    // 第2引数で指定したCallback型のDelegateで処理するものです。
    async static void HttpRequest(String url, Callback callback) // (3)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            // HttpClientクラスを使って、第1引数に指定したURLにアクセスして、
            // そのHTTPレスポンスを取得します。
            HttpResponseMessage res = await httpClient.GetAsync(url);

            // 第2引数で指定したCallback型のDelegateで
            // 先程取得したHTTPレスポンスを処理します。
            callback(res);
        }
    }
}


