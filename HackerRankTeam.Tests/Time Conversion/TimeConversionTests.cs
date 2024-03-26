using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTeam.UnitTest.Time_Conversion
{
    [TestFixture]
    public class TimeConversionTests
    {
        //Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
        // Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        //- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
        [Test]
        [TestCase("12:20:00","122000")]
        public void TimeConversions_RemoveColon_ReturnMilitaryTime(string input, string expectedResult) 
        {
            var result = TimeConversions(input);

            Assert.That(result, Is.EqualTo(expectedResult));

        }

        public static string TimeConversions(string s)
        {
            string hours, minutes, seconds, time;

            char[] timeArray = s.ToCharArray();
            hours = Convert.ToString(timeArray[0]) + Convert.ToString(timeArray[1]);
            minutes = Convert.ToString(timeArray[3]) + Convert.ToString(timeArray[4]);
            seconds = Convert.ToString(timeArray[6]) + Convert.ToString(timeArray[7]);
            time = hours + minutes + seconds;

            

            return time;

        }
    }
}
