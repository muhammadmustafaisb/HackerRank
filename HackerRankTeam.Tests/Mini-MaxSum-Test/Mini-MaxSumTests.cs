
namespace HackerRankTeam.UnitTest.Mini_MaxSum_Test
{
    [TestFixture]
    public class Mini_MaxSumTests
    {
        [Test]
        public void MiniMaxSum_AddFourOutFive_ReturnTotal() 
        {
            List<int> testArray1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> testArray2 = new List<int> { 5, 4, 3, 2, 1 };
            List<int> testArray3 = new List<int> { 9, 1, 2, 3, 4 };

            // Assert
            AssertOutput(testArray1, "10 14");
            AssertOutput(testArray2, "10 14");
            AssertOutput(testArray3, "10 18");
        }

        private void AssertOutput(List<int> arr, string expectedOutput)
        {

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Mini_MaxSum.Mini_MaxSum.MiniMaxSum(arr);
                string actualOutput = sw.ToString().Trim();
                Assert.That(actualOutput, Is.EqualTo(expectedOutput));
            }
        }
    }
}
