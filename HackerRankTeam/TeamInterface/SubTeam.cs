
namespace HackerRankTeam
{
    public class SubTeam : Team 
    {
        public SubTeam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
        {
        }

        public void ChangeTeamName(string name)
        {
            teamName = name;
        }
    }
}
