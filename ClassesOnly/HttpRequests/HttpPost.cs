using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOnly.HttpRequests
{
    public class HttpPost
    {
        public int StatusCode { get; set; }
        public HttpResponseMessage HttpResponseMessage;

        private string url;

        private readonly string token;
        private readonly HttpClient httpClient = new HttpClient();
        private string bodyJson;
        private StringContent stringContentBodyJson;

        #region CTOR        
        public HttpPost(string url, string bodyJson)
        {
            if (bodyJson == null || bodyJson.Length < 1) throw new Exception("Body is empty!");

            this.url = url;
            this.bodyJson = bodyJson;
        }

        public HttpPost(string url, string bodyJson, string token) : this(url, bodyJson)
        {
            this.token = token;
        }

        public HttpPost(string url, string bodyJson, string token, Dictionary<string, string> queryStringParameters)
        {
            if (bodyJson == null || bodyJson.Length < 1) throw new Exception("Body is empty!");

            this.url = url;
            this.bodyJson = bodyJson;
            this.token = token;

            this.BuildParameters(queryStringParameters);
        }
        #endregion

        #region PUBLICS        
        public async Task SendRequestAsync()
        {
            this.BuildAuthorization();

            this.BuildBody();

            await this.SendAndBuildResponseAsync();
        }

        public async Task SendRequestAsync(Dictionary<string, string> parameters)
        {
            this.BuildAuthorization();

            this.BuildParameters(parameters);

            this.BuildBody();

            await this.SendAndBuildResponseAsync();
        }

        // Converter methods
        public Task<string> ConvertToStringAsync()
        {
            return this.HttpResponseMessage.Content.ReadAsStringAsync();
        }

        public async Task<T> ConvertToTAsync<T>()
        {
            return JsonConvert.DeserializeObject<T>(await this.ConvertToStringAsync());
        }
        #endregion

        #region PRIVATES        
        // PRIVATES ---------------------------------------------------------------->
        private void BuildParameters(Dictionary<string, string> parameters)
        {
            if (parameters.Count > 0)
            {
                this.url += "?";

                int i = 1;
                foreach (KeyValuePair<string, string> line in parameters)
                {
                    this.url += line.Key + "=" + line.Value;

                    if (i < parameters.Count) this.url += "&";

                    i++;
                }
            }
        }

        private void BuildAuthorization()
        {
            if (this.token != null)
            {
                this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", this.token);
            }
        }

        private void BuildBody()
        {
            this.stringContentBodyJson = new StringContent(this.bodyJson, Encoding.UTF8, "application/json");
        }

        private async Task SendAndBuildResponseAsync()
        {
            this.HttpResponseMessage = await this.SendPostAsync();

            this.StatusCode = (int)HttpResponseMessage.StatusCode;
        }

        private Task<HttpResponseMessage> SendPostAsync()
        {
            return this.httpClient.PostAsync(this.url, this.stringContentBodyJson);
        }
        #endregion
    }
}
