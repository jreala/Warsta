namespace Warsta.Authentication
{
    public class Logout
    {
        public string ApplicationId;
        public string AccessToken;

        public Logout (string ApplicationId, string AccessToken)
        {
            this.ApplicationId = ApplicationId;
            this.AccessToken = AccessToken;
        }
    }
}