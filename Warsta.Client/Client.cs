using RestSharp;
using RestSharp.Authenticators;

namespace Warsta.Client
{
    public class Client
    {
        private readonly string ApplicationId;
        public static readonly RestClient TanksClient = new RestClient ("https://api.worldoftanks.com/wot/");
        public static readonly RestClient BlitzClient = new RestClient ("https://api.wotblitz.com/wotb/");
        public static readonly RestClient WarshipsClient = new RestClient ("https://api.worldofwarships.com/");
        public static readonly RestClient WarplanessClient = new RestClient ("https://api.worldofwarplanes.com/");
        public static readonly RestClient XboxClient = new RestClient ("https://api-xbox-console.worldoftanks.com/wotx/");
        public static readonly RestClient Ps4Client = new RestClient ("https://api-ps4-console.worldoftanks.com/wotx/");

        public Client (string ApplicationId)
        {
            this.ApplicationId = ApplicationId;
        }
    }
}