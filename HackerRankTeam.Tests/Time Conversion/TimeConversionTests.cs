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
        [TestCase("12:00:00AM", "00:00:00")]
        [TestCase("12:01:00AM", "00:01:00")]
        [TestCase("12:00:00PM", "12:00:00")]
        [TestCase("01:15:00PM", "13:15:00")]
        [TestCase("11:59:59PM", "23:59:59")]
        public void TimeConversions_RemoveAmPm_ReturnMilitaryTime(string input, string expectedResult)
        {
            var result = TimeConversion.TimeConversion.TimeConversions(input);

            Assert.That(result, Is.EqualTo(expectedResult));

        }

    }
}
