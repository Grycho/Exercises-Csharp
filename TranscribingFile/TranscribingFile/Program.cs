using System;
using System.Net.Http;

namespace TranscribingFile
{
    class Program
    {
        //api key, important for merge
        static string API_Key = "aa4f8bdce5e14cefbc538f4351f1d379";

        static void Main(string[] args)
        {
            //HttpClient is normally created once, then used for all message sending
            HttpClient client = new HttpClient();
            //set the base address for the API endpoint
            client.BaseAddress = new Uri("https://api.assemblyai.com/v2/");
        }
    }
}
