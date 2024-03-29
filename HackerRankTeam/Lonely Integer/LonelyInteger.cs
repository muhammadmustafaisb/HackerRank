using System.ComponentModel;

namespace HackerRankTeam.Lonely_Integer
{
    public class LonelyInteger
    {
        public static int FindUniqueElement(List<int> arr)
        {
            int uniqueElement = 0;

            for (int i = 0; i < arr.Count; i++) 
            {
                int count = 0;

                for (int j = 0; j < arr.Count; j++) 
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
