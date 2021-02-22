using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassesOnly.HttpRequests
{
    public class HttpGet
    {
        public bool Successed { get; set; }
        public int StatusCode { get; set; }

        private string uri;
        private string token;

        #region CTOR        
        public HttpGet(string uri, string token)
        {
            this.uri = uri;
            this.token = token;
        }

        public HttpGet(string uri, string token, Dictionary<string, string> parameters) : this(uri, token)
        {
            this.BuildParameters(parameters);
        }
        #endregion

        #region PUBLICS        
        public Task<string> SendRequestAsync()
        {
            return this.Send();
        }

        public static JObject ToJObject(string responseInString)
        {
            return JObject.Parse(responseInString);
        }

        public static T ToObject<T>(string responseInString)
        {
            return JsonConvert.DeserializeObject<T>(responseInString);
        }

        public static List<T> ToObjectList<T>(string responseInString)
        {
            return JsonConvert.DeserializeObject<List<T>>(responseInString);
        }
        #endregion

        #region PRIVATES        
        // PRIVATES ---------------------------------------------------------------->
        private void BuildParameters(Dictionary<string, string> parameters)
        {
            if (parameters.Count > 0)
            {
                this.uri += "?";

                int i = 1;
                foreach (KeyValuePair<string, string> line in parameters)
                {
                    this.uri += line.Key + "=" + line.Value;

                    if (i < parameters.Count) this.uri += "&";

                    i++;
                }
            }
        }

        private async Task<string> Send()
        {
            string responseString = null;

            using (var httpClient = new HttpClient())
            {
                if (this.token != null)
                {
                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", this.token);
                }

                using (var response = await httpClient.GetAsync(this.uri))
                {
                    this.StatusCode = (int)response.StatusCode;

                    if (response.IsSuccessStatusCode)
                    {
                        responseString = await response.Content.ReadAsStringAsync();
                    }
                }
            }

            return responseString;
        }
        #endregion
    }
}
