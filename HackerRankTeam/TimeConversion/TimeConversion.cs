

namespace HackerRankTeam.TimeConversion
{
    public class TimeConversion
    {
        public static string TimeConversions(string s)
        {
            DateTime parsedTime = DateTime.Parse(s);

            string militaryTime = parsedTime.ToString("HH:MM:SS");

            return militaryTime;
        }
    }
}
