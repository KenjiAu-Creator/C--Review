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
      // Trim() will remove all leading and trailing whitespace (newlines, spaces, tabs, etc..)
      name = Console.ReadLine().Trim();

      // Condition is an expression that evalutes to either true or false.
      // True runs the "if" side, false runs the "else" side.
      // Roughlt equivalent to name == "", except it also treats null as empty.
      // White space sohuld be already trimmed, but the extra layer doesn't hurt.
      if (string.IsNullOrWhiteSpace(name))
      {
        Console.WriteLine("Invalid Input: Please enter a name:");
      }
      else if ((name.ToLower() == "Admin".ToLower()) )
      {
        Console.WriteLine("Administrative access granted.");
      }
      else
      {
        // Output to the console.
        // Concatenation.
        Console.WriteLine("Hello " + name + "! What a nice day!");

        // Parameterized Output.
        Console.WriteLine("Hello {0}! What a nice day todaty!", name);

        // String interpolation.
        Console.WriteLine($"Hello {name}! What a nice day today!");
      }
    }
  }
  // Exit point of programs in C#.
}
