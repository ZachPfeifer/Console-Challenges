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




  }
}
