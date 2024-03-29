namespace HackerRankTeam.UnitTest.Lonely_Integer
{
    [TestFixture]
    public class Lonely_IntegerTests
    {
        [Test]
        [TestCase(new int[] { 1, 1, 2, 2, 3 }, 3)]
        [TestCase(new int[] { 4, 4, 5, 7, 5, 6, 6}, 7)]
        [TestCase(new int[] { 9, 8, 7, 8, 9 }, 7)]
        public void TestFindUniqueElement(int[] arr,int Output)
        {
 

            var result = Lonelyinteger(arr);

            Assert.That(result, Is.EqualTo(Output));
        }

        public static int Lonelyinteger(int[] arr)
        {
            int uniqueElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }

                }
                if (count == 1)
                {
                    uniqueElement = arr[i];
                    break;
                }
            }
            return uniqueElement;
        }
    }
}
