using HackerRankTeam.ArrayOfIntegers;

public class Program
{
    public static void Main(string[] args) 
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        PlusMinus.PlusMinusFun(arr);
    }
}
