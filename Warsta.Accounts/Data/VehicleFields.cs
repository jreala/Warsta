namespace Warsta.Accounts.Data
{
    public class VehicleFields
    {
        public readonly string MarkOfMastery = "mark_of_mastery";
        public readonly string TankId = "tank_id";
        public object Statistics = new { Battles = "statistics.battles", Wins = "statistics.wins" };
    }
}