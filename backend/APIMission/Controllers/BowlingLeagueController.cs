using APIMission.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIMission.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingLeagueController(IBowlingRepository temp) {
            _bowlingRepository = temp; 
        }

        [HttpGet]
        public IEnumerable<Object> Get()
        {
                  var joinedData = from bowler in _bowlingRepository.Bowlers
                                     join team in _bowlingRepository.Teams
                                     on bowler.TeamId equals team.TeamId
                                     where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                                     select new
                                     {
                                         BowlerId = bowler.BowlerId,
                                         BowlerFirstName = bowler.BowlerFirstName,
                                         BowlerMiddleInit = bowler.BowlerMiddleInit,
                                         BowlerLastName = bowler.BowlerLastName,
                                         BowlerAddress = bowler.BowlerAddress,
                                         BowlerCity = bowler.BowlerCity,
                                         BowlerState = bowler.BowlerState,
                                         BowlerZip = bowler.BowlerZip,
                                         BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                         TeamName = team.TeamName
                                     };

            var joinedList = joinedData.ToList();
            return joinedList;

        }
    }
}
