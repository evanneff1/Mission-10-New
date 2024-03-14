
using Microsoft.EntityFrameworkCore;

namespace APIFun.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _context;
        public EFBowlerRepository(BowlerContext temp) {
            _context = temp;
        }
        public IEnumerable<Bowler> Bowlers => _context.Bowlers;

        public IEnumerable<Team> Teams => _context.Teams;

        public IEnumerable<BowlerTeamInfo> GetBowlerTeamInfo()
        {
            var bowlerTeamInfo = _context.Bowlers.Include(b => b.Team)  // Assuming _context is your DbContext
                                .Select(b => new BowlerTeamInfo
                                {
                                    BowlerName = b.BowlerFirstName + " " + b.BowlerMiddleInit + " " + b.BowlerLastName,  // Assuming you have a Name property
                                    TeamName = b.Team.TeamName,
                                    Address = b.BowlerAddress + " " + b.BowlerCity + ", " + b.BowlerState + " " + b.BowlerZip,
                                    Phone = b.BowlerPhoneNumber

                                }).Where(b=>b.TeamName == "Marlins" | b.TeamName == "Sharks").ToArray();

            return bowlerTeamInfo;
        }
    }


}
