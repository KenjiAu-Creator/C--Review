using System;
using System.Threading.Tasks.Dataflow;

namespace CSharpReview
{
  class Program
  {
    // Entry point of programs in C#
    static void Main(string[] args)
    {
      // Declaration of variable.
      string name; // String value.


      char character; // A single character value.
      bool aBoolean; // True or false values (bit)

      byte aByte; // Super small integer values.(~120 max)
      double aDouble; //  Decimal values
      decimal aDecimal; // Also decimal values (extremely precise).
      float aFloat; // Floating point values (Less precision than doubles).
      int anInt; // Integer values. (~210000000 max)
      long aLongInt; // BIG Integer values.
      short aShortInt; // small integer values; (~65000 max)

      int userInput;
      string output;
      Console.WriteLine("Please enter a number:");

      userInput = int.Parse(Console.ReadLine());
      // Switch works with discrete values, not ranges like if allows, but osme people find it more readable.
      // Anything* you can do weith a switch you can do with an if/else.
      // * Falling through cases is questionable with if/else as you need some other logic,
      //but its questionable whether that should be done anyways.

      for (int i =1; i <= userInput; i++ )
      {
        Console.WriteLine(i);
      }

      // Initialize
      int y = 1;
      // Test
      while (y < userInput)
      {
        // Process
        Console.WriteLine(y);
        y++;
      }

      // Post-Test Loop. Always runs atleast once, even if condition is false.
      int z = 1; // Initialize
      do
      {
        Console.WriteLine(z); // Process
        z++;  // Modify
      }
      while (z <= userInput); // Test

      // Arrays in C# are fixed-length collections of items.
      // [0, 1, 2, 3, 4]
      int[] intArray = new int[5];

      // IF we want to set itm just like most other languages, we can set an element by assigning an index.

      intArray[3] = 10;

      for (int i =0; i < intArray.Length; i++ )
      {
        Console.WriteLine(intArray[i]);
      }

      /*
       * static: Tells C# tto only keep one copy of the method in memory (important for OOP)
       * int: Return type, the type of data coming out of the method.
       * GetInt: Name of the method, how we call it.
       * string: First parameter type, the type of input expected.
       * prompt: First parameter / arguement name, how we refer to that value in the method.
       */

      static int GetInt(string Prompt)
      {

        int input;
        Console.WriteLine(Prompt);
        input = int.Parse(Console.ReadLine());
        return input;
      }
    }
  }
  // Exit point of programs in C#.
}
