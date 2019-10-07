using System;

namespace Challenges
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Hello World! It's Challenge Time");
      Console.WriteLine(" ");

      Console.WriteLine("Double Integer");
      // num will be an integer. Double it and return it. (ex 12 => 24)
      System.Console.WriteLine(Challenges.DoubleInt(7) + " = 14?");
      //   System.Console.WriteLine(Challenges.DoubleInt(7.5) + " = 15?");
      //   System.Console.WriteLine(Challenges.DoubleInt(7.5f) + " = 15?");

      Console.WriteLine(" ");
      Console.WriteLine("Is Number Even?");
      //num will be an integer. Return true if it’s even, and false if it isn’t.
      System.Console.WriteLine(Challenges.IsNumberEven(7) + " = False?");
      System.Console.WriteLine(Challenges.IsNumberEven(6) + " = True?");

      Console.WriteLine(" ");
      Console.WriteLine("What File Extension Name?");
      // str will be a string, but it may not have a file extension.
      // return the file extension (with no period) if it has one, otherwise false
      System.Console.WriteLine(Challenges.GetFileExtension("hello.txt") + " = txt?");

      Console.WriteLine(" ");
      Console.WriteLine("Longest String?");
      // arr will be an array. Return the longest string in the array
      System.Console.WriteLine(Challenges.LongestString(new string[] { "a", "b", "c", "cd" }) + " = cd?");

      Console.WriteLine(" ");
      Console.WriteLine("Sum of the Array?");
      //given an array return the sum of all its values
      System.Console.WriteLine(Challenges.arraySum(new int[] { 10, 10, 10, 10, 10 }) + " = 50?");






    }

  }
}
