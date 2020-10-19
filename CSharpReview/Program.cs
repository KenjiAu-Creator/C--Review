using System;

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
    }
  }
  // Exit point of programs in C#.
}
