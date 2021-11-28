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
            //the base address for the API endpoint
            client.BaseAddress = new Uri("https://api.assemblyai.com/v2/");
            //the request header
            client.DefaultRequestHeaders.Add("authorization", API_Key);
        }

        private static async Task<string> SendFile(HttpClient client, string filePath)
        {
            try
            {

            }
            catch(Exception ex)
            {
                System.Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }
    }
}