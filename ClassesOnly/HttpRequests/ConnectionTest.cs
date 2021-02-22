using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassesOnly.HttpRequests
{
    public static class ConnectionTest
    {
        public static string ApiConnectionTestUri;

        public async static Task<bool> Test(bool useHttpRequestHandler)
        {
            HttpGet get = new HttpGet(Informations.ApiUris.ConnectionTestUri, null);

            if (useHttpRequestHandler)
            {
                await ExceptionsHandling.HandleHttpRequest.HandleGetAsync(get);
            }
            else
            {
                await get.SendRequestAsync();
            }

            if (get.StatusCode == 204) return true;
            else return false;
        }
    }
}
