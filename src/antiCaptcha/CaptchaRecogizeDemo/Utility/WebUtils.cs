using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace CaptchaRecogizeDemo.Utility
{
    public static class WebUtils
    {
        private const int LargeBufferSize = 8192;

        public static async Task DownloadAsync(Uri requestUri, string filePath)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, requestUri))
                {
                    using (
                        Stream contentStream = await (await httpClient.SendAsync(request)).Content.ReadAsStreamAsync(),
                        stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, LargeBufferSize, true))
                    {
                        await contentStream.CopyToAsync(stream);
                    }
                }
            }
        }

        internal static MemoryStream DownloadStreamAsync(string requestUri)
        {
            MemoryStream ms = new MemoryStream();
            using (var httpClient = new HttpClient())
            {
                Stream contentStream = httpClient.GetAsync(requestUri).Result.Content.ReadAsStreamAsync().Result;
                contentStream.CopyTo(ms);
            }
            ms.Seek(0, SeekOrigin.Begin);
            return ms;
        }
    }
}
