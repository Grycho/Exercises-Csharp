using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

            string jsonResult = SendFile(client, @"E:\Moje wszystko\VOICE_B_T\FOLDER01\01_10_2021_N_M.mp3").Result;

            Console.WriteLine(jsonResult);

            client.Dispose();
            client = new HttpClient();
            //the base address for the API endpoint
            client.BaseAddress = new Uri("https://api.assemblyai.com/v2/");
            //the request header
            client.DefaultRequestHeaders.Add("authorization", API_Key);

            var json = new { audio_url = JsonConvert.DeserializeObject<UploadItem>(jsonResult).upload_url };

            //create a string content from JSON
            StringContent payload = new StringContent(JsonConvert.SerializeObject(json), Encoding.UTF8, "application/json");

            
        }

        private static async Task<string> SendFile(HttpClient client, string filePath)
        {
            try
            {
                //new HTTP request of type post method, we will use the upload API for endpoint
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "upload");
                //the request header
                request.Headers.Add("Transer-Encoding", "chunked");
                //read the file
                var fileReader = System.IO.File.OpenRead(filePath);
                //read the file as a stream using our file reader object
                var streamContent = new StreamContent(fileReader);
                //the request content to our data stream
                request.Content = streamContent;
                //send the request
                HttpResponseMessage response = await client.SendAsync(request);

                //return the response as a string!
                return await response.Content.ReadAsStringAsync();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }
    }

    class UploadItem
    {
        public string upload_url { get; set; }
    }
}