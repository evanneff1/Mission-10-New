using System.ComponentModel.DataAnnotations;

namespace APIFun.Data
{
    public class Bowler
    {
        [Key]
        public int BowlerID { get; set; }
        public string BowlerLastName { get; set; }

        public string BowlerFirstName { get; set; }

        public string ? BowlerMiddleInit { get; set; }

        public string BowlerAddress { get; set; }

        public string BowlerCity { get; set; }

        public string BowlerState { get; set; }

        public string BowlerZip { get; set; }

        public string BowlerPhoneNumber { get; set; }

        public int TeamID { get; set; }
        public Team Team { get; set; }



    }

    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        public string TeamName { get; set; }

        public int CaptainID { get; set; }

        public List<Bowler> Bowlers { get; set; }
    }
}
