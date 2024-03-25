
namespace HackerRankTeam.ArrayOfIntegers
{
    public class PlusMinus
    {
        //1.	Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
        //Print the decimal value of each fraction on a new line with 6 places after the decimal.

        public static void PlusMinusFun(int[] arr)
        {
            decimal positiveCount = 0;
            decimal negativeCount = 0;
            decimal zeroCount = 0;
            decimal length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }

                else if (arr[i] < 0)
                {
                    negativeCount++;
                }

                else
                {
                    zeroCount++;
                }
            }

            Console.WriteLine(positiveCount / length);
            Console.WriteLine(negativeCount / length);
            Console.WriteLine(zeroCount / length);

        }
    }
}
