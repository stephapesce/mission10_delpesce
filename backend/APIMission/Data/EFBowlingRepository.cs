
namespace APIMission.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _Bowlingcontext;
        public EFBowlingRepository(BowlingLeagueContext temp) { 
            _Bowlingcontext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _Bowlingcontext.Bowlers;
        public IEnumerable<Team> Teams => _Bowlingcontext.Teams;


    }
}
