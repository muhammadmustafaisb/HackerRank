using HackerRankTeam.ArrayOfIntegers;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace HackerRankTeam.UnitTest.Plus
{
    [TestFixture]
    public class PlusMinusTests
    {
        [Test]
        public void plusMinus_DivideByTotal_ReturnSixDecimal() 
        {
            int[] arr = { 1, -2, 3, 0, -5 };
            string[] expectedOutput = { "0.4", "0.4", "0.2" };

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            PlusMinus.PlusMinusFun(arr);

            string[] actualOutput = sw.ToString().Trim().Split(Environment.NewLine);

            Assert.That(actualOutput.Length, Is.EqualTo(expectedOutput.Length));

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.That(expectedOutput[i], Is.EqualTo(actualOutput[i]));
            }

        }

    }
}
