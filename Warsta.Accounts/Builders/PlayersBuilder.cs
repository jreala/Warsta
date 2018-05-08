namespace Warsta.Accounts.Builders
{
    public class PlayersBuilder
    {
        public string ApplicationId { get; private set; }
        public string Search { get; private set; }
        public string Fields { get; private set; }
        public string Language { get; private set; }
        public int Limit { get; private set; }
        public string Type { get; private set; }

        public PlayersBuilder (string ApplicationId, string Search)
        {
            this.ApplicationId = ApplicationId;
            this.Search = Search;
        }

        public PlayersBuilder (string ApplicationId, string Search, string Fields) : this (ApplicationId, Search)
        {
            this.Fields = Fields;
        }

        public PlayersBuilder (string ApplicationId, string Search, string Fields, string Language) : this (ApplicationId, Search, Fields)
        {
            this.Language = Language;
        }

        public PlayersBuilder (string ApplicationId, string Search, string Fields, string Language, int Limit) : this (ApplicationId, Search, Fields, Language)
        {
            this.Limit = Limit;
        }

        public PlayersBuilder (string ApplicationId, string Search, string Fields, string Language, int Limit, string Type) : this (ApplicationId, Search, Fields, Language, Limit)
        {
            this.Type = Type;
        }

        public PlayersBuilder WithFields (string fields)
        {
            this.Fields = fields;
            return this;
        }

        public PlayersBuilder WithLanguage (string language)
        {
            this.Language = language;
            return this;
        }

        public PlayersBuilder WithLimit (int limit)
        {
            this.Limit = limit;
            return this;
        }

        public PlayersBuilder WithType (string type)
        {
            this.Type = type;
            return this;
        }
    }
}