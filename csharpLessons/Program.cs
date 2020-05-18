using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace csharpLessons
{
  class Solution
  {
    static void Main()
    {
      Solution a = new Solution();
      Console.WriteLine(new Solution().ArrayRankTransform(new int[] { 40,10,20,30,10,10,10}));
    }

    public int[] ArrayRankTransform(int[] arr)
    {
      int[] distinctArray = arr.Distinct().ToArray();
      Array.Sort(distinctArray);
      Dictionary<int, int> dictionary = new Dictionary<int, int>();
      for (int i=0; i<distinctArray.Length; i++)
      {
        dictionary.Add(distinctArray[i], i+1);
      }
      int[] answer = new int[arr.Length];
      for (var i=0; i<arr.Length; i++)
      {
        answer[i] = dictionary[arr[i]];
      }
      return answer;
    }
  }

}