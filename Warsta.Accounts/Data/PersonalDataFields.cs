namespace Warsta.Accounts.Data
{
    public class PersonalDataFields
    {
        public readonly string AccountId = "account_id";
        public readonly string ClanId = "clan_id";
        public readonly string ClientLanguage = "client_language";
        public readonly string CreatedAt = "created_at";
        public readonly string GlobalRating = "global_rating";
        public readonly string LastBattleTime = "last_battle_time";
        public readonly string LogoutAt = "logout_at";
        public readonly string Nickname = "nickname";
        public readonly string UpdatedAt = "updated_at";
        public AllTimeStatisticsFields AllTime = new AllTimeStatisticsFields ();
        public ClanStatisticFields Clan = new ClanStatisticFields ();
        public CompanyStatisticsFields Company = new CompanyStatisticsFields ();
        public EpicStatisticFields Epic = new EpicStatisticFields ();
        public PrivateFields Private = new PrivateFields ();
        public StatisticsFields Statistics = new StatisticsFields ();
    }
}