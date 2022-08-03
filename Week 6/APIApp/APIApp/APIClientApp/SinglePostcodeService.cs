using Newtonsoft.Json.Linq;
using RestSharp;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure.Design;

namespace APIClientApp
{
    public class SinglePostcodeService
    {
        #region properties
        public RestClient Client { get; set; }
        public RestResponse Response { get; set; }
        public JObject ResponseContent { get; set; }

        #endregion
        public SinglePostcodeService()
        {
            Client = new RestClient(AppConfigReadercs.BaseUrl);
        }

        public async Task MakesRequestAsync(string postcode)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Resource = $"postcode/{postcode.ToLower().Replace(" ", "")}";

            Response = await Client.ExecuteAsync(request);

            ResponseContent = JObject.Parse(Response.Content);
        }

        public int GetStatusCode()
        {
            return (int)Response.StatusCode;
        }
    }
}
