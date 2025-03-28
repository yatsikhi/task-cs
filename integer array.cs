using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 1, 3, 2, 5 };
        int[] result = FindSingleElements(nums);
        Console.WriteLine("Вывод: [" + result[0] + ", " + result[1] + "]");
    }

    static int[] FindSingleElements(int[] nums)
    {
        Dictionary<int, int> countMap = new Dictionary<int, int>();

        
        foreach (int num in nums)
        {
            if (countMap.ContainsKey(num))
            {
                countMap[num]++;
            }
            else
            {
                countMap[num] = 1;
            }
        }

        List<int> result = new List<int>();
        
        foreach (var pair in countMap)
        {
            if (pair.Value == 1)
            {
                result.Add(pair.Key);
            }
        }

        return result.ToArray();
    }
}
