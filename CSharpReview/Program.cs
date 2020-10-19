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


      // Write a prompt
      // Write will keep the cursor on the same line, WriteLine will not.
      Console.Write("Please enter your name: ");

      // Input from the consle. Console.ReadLine()
      name = Console.ReadLine();

      // Output to the console.
      // Concatenation.
      Console.WriteLine("Hello " + name + "! What a nice day!");

      // Parameterized Output.
      Console.WriteLine("Hello {0}! What a nice day todaty!", name);

      // String interpolation.
      Console.WriteLine($"Hello {name}! What a nice day today!");
    }
  }
  // Exit point of programs in C#.
}
