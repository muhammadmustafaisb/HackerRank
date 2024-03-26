
namespace HackerRankTeam.Mini_MaxSum
{
    public class Mini_MaxSum
    {
        //Given five positive integers, find the minimum and maximum values
        //that can be calculated by summing exactly four of the five integers.
        //Then print the respective minimum and maximum values
        //as a single line of two space-separated long integers.
        public static void MiniMaxSum(List<int> arr)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double num5 = 0;
            int length = arr.Count;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] < 0) 
                {
                    break;
                }
                else if (i == 0) 
                { 
                    num1 = arr[i];
                }
                else if (i == 1)
                {
                    num2 = arr[i];
                }
                else if (i == 2)
                {
                    num3 = arr[i];
                }
                else if (i == 3)
                {
                    num4 = arr[i];
                }
                else if (i == 4)
                {
                    num5 = arr[i];
                }
            }

            double r1 = num2 + num3 + num4 + num5;
            double r2 = num1 + num3 + num4 + num5;
            double r3 = num1 + num2 + num4 + num5;
            double r4 = num1 + num2 + num3 + num5;
            double r5 = num1 + num2 + num3 + num4;

            if (r1 >= r2 && r2 <= r3 && r2 <= r4 && r2 <= r5)
            {
                Console.Write(r2 + " ");
            }

            else if (r2 >= r1 && r1 <= r3 && r1 <= r4 && r1 <= r5)
            {
                Console.Write(r1 + " ");
            }

            else if (r2 >= r3 && r3 <= r1 && r3 <= r4 && r3 <= r5)
            {
                Console.Write(r3 + " ");
            }

            else if (r2 >= r4 && r4 <= r3 && r4 <= r1 && r4 <= r5)
            {
                Console.Write(r4 + " ");
            }

            else if (r2 >= r5 && r5 <= r3 && r5 <= r4 && r5 <= r1)
            {
                Console.Write(r5 +" ");
            }

            if (r1 <= r2 && r2 >= r3 && r2 >= r4 && r2 >= r5)
            {
                Console.Write(r2 + " ");
            }

            else if (r2 <= r1 && r1 >= r3 && r1 >= r4 && r1 >= r5) 
            {
                Console.Write(r1 + " ");
            }

            else if (r2 <= r3 && r3 >= r1 && r3 >= r4 && r3 >= r5)
            {
                Console.Write(r3 + " ");
            }

            else if (r2 <= r4 && r4 >= r3 && r4 >= r1 && r4 >= r5)
            {
                Console.Write(r4 + " ");
            }

            else if (r2 <= r5 && r5 >= r3 && r5 >= r4 && r5 >= r1)
            {
                Console.Write(r5 + " ");
            }
        }
    }
}
