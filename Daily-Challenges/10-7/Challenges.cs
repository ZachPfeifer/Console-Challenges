using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Challenges
{
  public static class Challenges
  {
    // num will be an integer. Double it and return it. (ex 12 => 24)
    public static int DoubleInt(int num) //can use Float and Double
    {
      return num + num;
    }

    //num will be an integer. Return true if it’s even, and false if it isn’t.
    public static bool IsNumberEven(int num) //can use Float and Double
    {
      return num % 2 == 0;
    }

    // str will be a string, but it may not have a file extension.
    // return the file extension (with no period) if it has one, otherwise false
    public static string GetFileExtension(string x)
    {
      string[] filename = x.Split('.');
      if (filename.Length > 1)
      {
        return filename[^1]; // '^' means count the end position 
      }

      return null;
    }

    // arr will be an array. Return the longest string in the array
    public static string LongestString(string[] x)
    {
      string longest = "";
      for (int i = 0; i < x.Length; i++)
      {
        string current = x[i];
        if (current.Length > longest.Length)
        {
          longest = current;
        }
      }
      return longest;
    }


    //given an array return the sum of all its values
    public static int arraySum(int[] x) //can use Float and Double
    {
      int sum = 0;
      for (int i = 0; i < x.Length; i++)
      {
        sum += x[i];
      }
      return sum;
    }


    //Write a function that will loop over an array and group all similar values in sub arrays Example group([1,1,3,4,5,4]) => output [[1,1],[3],[4,4],[5]
    public static List<List<int>> ArrayGroup(int[] arr)
    {
      //Create a Dictionary
      Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
      //Loop over Array and add each value as a key if it doesnt exist
      foreach (int val in arr)
      {
        //If it doesnt exist
        if (dict.ContainsKey(val))
        {
          //add new list
          dict.Add(val, new List<int>());
        }
        //push into an array at that key
        dict[val].Add(val);
      }
      //Return Dictionary Values as an Array
      return dict.Values.ToList();
    }


    //Take 2 on Arraygroup
    public static int[][] ArrayGroup2(int[] arr)
    {
      //Create a Dictionary
      Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
      //Loop over Array and add each value as a key if it doesnt exist
      foreach (int val in arr)
      {
        //If it doesnt exist
        if (dict.ContainsKey(val))
        {
          //add new list
          dict.Add(val, new List<int>());
        }
        //push into an array at that key
        dict[val].Add(val);
      }
      //Return Dictionary Values as an Array
      var values = dict.Values.ToList();
      var inList = new List<int[]>();
      values.ForEach(v => inList.Add(v.ToArray()));
      return inList.ToArray();
    }


    //Kaprekar's constant The number 6174 is known as Kaprekar's constant. It is the ultimate convergence point of the Kaprekar's routine, an algorithm thought up by Indian mathematician D.R. Kaprekar in 1949. The routine is as follows: 1. Take any four-digit number (at least two different digits must be used, zeroes allowed). 2. Arrange the digits in descending and then in ascending order to get two four-digit numbers. 3. Subtract the smaller number from the larger and get the result. 4. Repeat steps 2-4 with the new number. After a few iterations, the algorithm converges to a fixed point and starts to result in the same number - 6174 - the so-called Kaprekar's constant. For Example: n = 5324 5432 - 2345 = 3087 8730 - 0378 = 8352 8532 - 2358 = 6174 7641 - 1467 = 6174 For numbers beyond four digits the routine might converge to 0 (zero), other constants or "loops" (infinitely repetitive sequences of the same numbers over and over again). Write a method which finds the number of itterations needed to reach Kaprekar's constant for any four-digit number.

    //Take 1
    public static int KaprekarConstant(int num)
    {
      int count = 0;
      // 1.) Take any four - digit number, using at least two different digits.
      while (num != 6174 && count < 16)
      {
        count++;
        //2.) Arrange the digits in descending and then in ascending order to get two four-digit numbers, adding leading zeros if necessary.

        //ascending
        string[] ascending = num.ToString().Split("");
        Array.Sort<string>(ascending);

        int a = int.Parse(String.Join("", ascending));

        // descending
        string[] descending = ascending;
        Array.Sort(descending);

        int d = int.Parse(String.Join("", descending.Reverse()));

        //3.) Subtract the smaller number from the bigger number.
        num = Math.Abs(a - d);
        System.Console.WriteLine(num);
      }
      //4.) Go back to step 2 and repeat.

      return count;
    }


    //Take 2
    public static int KaprekarConstant2(int num)
    {
      {
        int count = 0;
        while (num != 6174 && count < 16)
        {
          count++;
          int[] nums = new int[4];
          for (int i = 0; i < 4; i++)
          {
            nums[i] = num % 10;
            num /= 10;
          }
          Array.Sort(nums);

          int ascending = 0;
          foreach (int elem in nums)
          {
            ascending *= 10;
            ascending += elem;
          }
          Array.Reverse(nums);
          int descending = 0;
          foreach (int elem in nums)
          {
            descending *= 10;
            descending += elem;
          }
          System.Console.WriteLine(ascending + "-" + descending);
          num = Math.Abs(ascending - descending);
        }
        return count;
      }
    }

    //Take 3
    public static int KaprekarConstant3(int num)
    {
      int count = 0;
      while (num != 6174)
      {
        count++;
        //sort number ascending
        int a = int.Parse(new string(num.ToString().OrderByDescending(d => d).ToArray()));
        int d = int.Parse(new string(a.ToString().Reverse().ToArray()));
        System.Console.WriteLine(d + "-" + a);
        num = Math.Abs(d - a);
      }
      return count;
    }
  }
}
