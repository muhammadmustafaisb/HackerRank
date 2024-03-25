
namespace HackerRankTeam
{
    public class Team : ITeam
    {
        public string teamName;
        public int noOfPlayers;

        public Team(string teamName, int noOfPlayers)
        {
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayers;
        }

        public void AddPlayer(int count)
        {
            noOfPlayers += count;
        }

        public bool RemovePlayer(int count)
        {
            if (noOfPlayers - count < 0)
            {
                return false;
            }
            else
            {
                noOfPlayers -= count;
                return true;
            }
        }
    }
}
