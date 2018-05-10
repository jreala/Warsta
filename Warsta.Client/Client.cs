using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Warsta.Authentication;

namespace Warsta.Client
{
    public class Client
    {
        private const string APPLICATION_ID = "application_id";
        private readonly string ApplicationId;
        private readonly OpenIdLogin Authentication;

        public static readonly RestClient Tanks = new RestClient ("https://api.worldoftanks.com/wot/");
        public static readonly RestClient Blitz = new RestClient ("https://api.wotblitz.com/wotb/");
        public static readonly RestClient Warships = new RestClient ("https://api.worldofwarships.com/");
        public static readonly RestClient Warplaness = new RestClient ("https://api.worldofwarplanes.com/");
        public static readonly RestClient Xbox = new RestClient ("https://api-xbox-console.worldoftanks.com/wotx/");
        public static readonly RestClient Ps4 = new RestClient ("https://api-ps4-console.worldoftanks.com/wotx/");

        public Client (OpenIdLogin request)
        {
            this.ApplicationId = request.ApplicationId;
            this.Authentication = request;
        }

        public IRestResponse Login(RestClient client)
        {
            var request = new RestRequest(Authentication.Path, Method.POST);
            request.AddParameter(APPLICATION_ID, ApplicationId);
            return client.Execute(request);
        }
    }
}