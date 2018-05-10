namespace Warsta.Authentication
{
    public class AccessTokenExtension
    {
        public string ApplicationId;
        public string AccessToken;
        public int ExpiresAt;

        public AccessTokenExtension (string ApplicationId, string AccessToken)
        {
            this.ApplicationId = ApplicationId;
            this.AccessToken = AccessToken;
        }

        public AccessTokenExtension (string ApplicationId, string AccessToken, int ExpiresAt) : this (ApplicationId, AccessToken)
        {
            this.ExpiresAt = ExpiresAt;
        }
    }
}