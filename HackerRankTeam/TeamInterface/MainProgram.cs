
namespace HackerRankTeam
{
    public class MainProgram
    {
        public void MainCode() 
        {
            SubTeam subteam = new SubTeam("Team A", 10);
            Console.WriteLine($"Initial Team Name: {subteam.teamName}, No. of Players: {subteam.noOfPlayers}\n");

            subteam.ChangeTeamName("New Team A");
            Console.WriteLine($"Updated Team Name: {subteam.teamName}\n");

            subteam.AddPlayer(5);
            Console.WriteLine($"Updated No. of Players after adding: {subteam.noOfPlayers}\n");

            bool removed = subteam.RemovePlayer(3);
            Console.WriteLine($"Players removed successfully: {removed}, No. of Players now: {subteam.noOfPlayers}\n");

            removed = subteam.RemovePlayer(10);
            Console.WriteLine($"Players removed successfully: {removed}, No. of Players now: {subteam.noOfPlayers} \n");

            Thread.Sleep(5000);

        }

    }
}
