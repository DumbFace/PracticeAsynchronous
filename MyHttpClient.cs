using System.Diagnostics;

namespace TestPerformanceAsyncAwait;

class Program
{
    static  void Main(string[] args)
    {
        CallMethodAsyncAwaitRealWorldExample();
        CallMethodAsyncAwait();
        Console.ReadLine();
    }

    public static async Task CallMethodAsyncAwait()
    {
        IMyHttpClient client = new MyHttpClient();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string urlGoogle = "https://www.google.com/";
        string urlTruyenQQ = "https://truyenqqq.vn/";
        string urlNetTruyen = "https://www.nettruyenio.com/";
        string urlKenh14 = "https://kenh14.vn/";
        string urlLocPhuc = "https://locphuc.com.vn/";
        string urlMicrosoftDocument = "https://learn.microsoft.com/";
        string urlMongoOfficial = "https://www.mongodb.com/";

        string htmlGoold = await client.GetHtmlWebAsync(urlGoogle);
        string htmlTruyenQQ = await client.GetHtmlWebAsync(urlTruyenQQ);
        string htmlNetTruyen = await client.GetHtmlWebAsync(urlNetTruyen);
        string htmlKenh14 = await client.GetHtmlWebAsync(urlKenh14);
        string htmlLocPhuc = await client.GetHtmlWebAsync(urlLocPhuc);
        string htmlMicrosoftDocument = await client.GetHtmlWebAsync(urlMicrosoftDocument);
        string htmlMongoOfficial = await client.GetHtmlWebAsync(urlMongoOfficial);

        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed;

        Console.WriteLine($"CallMethodAsync is done in {elapsedTime}");
    }

    public static async Task CallMethodAsyncAwaitRealWorldExample()
    {
        IMyHttpClient client = new MyHttpClient();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string urlGoogle = "https://www.google.com/";
        string urlTruyenQQ = "https://truyenqqq.vn/";
        string urlNetTruyen = "https://www.nettruyenio.com/";
        string urlKenh14 = "https://kenh14.vn/";
        string urlLocPhuc = "https://locphuc.com.vn/";
        string urlMicrosoftDocument = "https://learn.microsoft.com/";
        string urlMongoOfficial = "https://www.mongodb.com/";

        Task<string> htmlGoold = client.GetHtmlWebAsync(urlGoogle);
        Task<string> htmlTruyenQQ = client.GetHtmlWebAsync(urlTruyenQQ);
        Task<string> htmlNetTruyen = client.GetHtmlWebAsync(urlNetTruyen);
        Task<string> htmlKenh14 = client.GetHtmlWebAsync(urlKenh14);
        Task<string> htmlLocPhuc = client.GetHtmlWebAsync(urlLocPhuc);
        Task<string> htmlMicrosoftDocument = client.GetHtmlWebAsync(urlMicrosoftDocument);
        Task<string> htmlMongoOfficial = client.GetHtmlWebAsync(urlMongoOfficial);

        await Task.WhenAll(
            htmlGoold,
            htmlTruyenQQ,
            htmlNetTruyen,
            htmlKenh14,
            htmlLocPhuc,
            htmlMicrosoftDocument,
            htmlMongoOfficial
            );

        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed;

        Console.WriteLine($"CallMethodAsyncAwaitRealWorldExample is done in {elapsedTime}");
    }

}
