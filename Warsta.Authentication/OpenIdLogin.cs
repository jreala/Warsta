namespace Warsta.Authentication
{
    public class OpenIdLogin
    {
        public readonly string Path = "auth/login/";
        public string ApplicationId;
        public string Display;
        public int ExpiresAt;
        public int NoFollow;
        public string RedirectUrl;

        public OpenIdLogin (string ApplicationId)
        {
            this.ApplicationId = ApplicationId;
        }

        public OpenIdLogin (string ApplicationId, int ExpiresAt) : this (ApplicationId)
        {
            this.ExpiresAt = ExpiresAt;
        }

        public OpenIdLogin (string ApplicationId, int ExpiresAt, int NoFollow) : this (ApplicationId, ExpiresAt)
        {
            this.NoFollow = NoFollow;
        }

        public OpenIdLogin (string ApplicationId, int ExpiresAt, string RedirectUrl) : this (ApplicationId, ExpiresAt)
        {
            this.RedirectUrl = RedirectUrl;
        }

        public OpenIdLogin (string ApplicationId, int ExpiresAt, string RedirectUrl, string Display) : this (ApplicationId, ExpiresAt, RedirectUrl)
        {
            this.Display = Display;
        }
    }
}