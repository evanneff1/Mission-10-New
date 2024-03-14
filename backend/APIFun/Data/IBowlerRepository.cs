namespace APIFun.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
        IEnumerable<BowlerTeamInfo> GetBowlerTeamInfo();
    }

    public class BowlerTeamInfo
    {
        // You can include other properties as needed
        public string BowlerName { get; set; }
        public string TeamName { get; set; }
        public string Address { get; internal set; }
        public string Phone { get; internal set; }
    }
}