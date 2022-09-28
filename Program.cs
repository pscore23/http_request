using System;
using System.Net.Http;


namespace HttpRequest {
    public static class Program {
        private static readonly Action<string> write = (text) => Console.WriteLine(text);
        private static readonly HttpClient _HttpClient = new HttpClient();

        public static void Main(string[] _) {
            string url = "https://scratch.mit.edu/";

            var HeadMessage = new HttpRequestMessage(HttpMethod.Head, url);
            var Response = _HttpClient.SendAsync(HeadMessage).Result;
            var Headers = Response.Headers;

            write($"ETag: {Headers.ETag?.Tag}");
        }
    }
}
