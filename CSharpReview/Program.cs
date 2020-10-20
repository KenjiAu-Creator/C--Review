using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace CSharpReview
{
  class Program
  {
    // Entry point of programs in C#
    static void Main(string[] args)
    {
/*      // Declaration of variable.
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
      // Anything* you can do with a switch you can do with an if/else.
      // * Falling through cases is questionable with if/else as you need some other logic,
      // but its questionable whether that should be done anyways.

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
      int[] intArray = new int[GetInt("Please enter in the size of the array")];

      for (int i =0; i < intArray.Length; i++ )
      {
        intArray[i] = GetInt("Please enter in an integer");
      }

      // foreach will loop over every item in a collection, however theyt are typically treated as readonly (with "normal" data types anyway.)
      foreach( int integer in intArray)
      {
        Console.WriteLine(integer);
      }

      List<int> intList = new List<int>();
      int userInput2 = 1;
      do
      {
        userInput2 = GetInt("Please enter a positive integer to add to the list, or negative one to exit:");
        if (userInput2 > 0)
        {
          intList.Add(userInput2);
        }
      } while (userInput2 > 0);
*/
      // In class practice:
      // Change the program to tkae in a list of names. Make sure the names are trimmed before they enter the list.
      // Change the GetInt() method to GetName()
      // Challenge: Prevent duplicates (Case insensitive) from being added.

/*      List<string> nameList = new List<string>();
      string studentName = "a";
      do
      {
        studentName = GetName("Please enter in the students name. Please enter in q to exit.");

        // Using the built in contains method for lists
*//*        if (!nameList.Contains(studentName))
        {
          nameList.Add(studentName);
        }*//*
        
        // James in-class method to solve using exist.
        *//*
        if (nameList.Exists(x => x.ToUpper() == studentName.ToUpper())
        {
          Console.WriteLine("That name is already i nthe list!");
        }
        else
        {
          nameList.Add(studentName);
        }
        *//*

        int count = 0;
        foreach( string nameInList in nameList)
        {
          if (nameInList.ToLower() == studentName.ToLower())
          {
            count++;
          }
        }

        if (count < 1)
        {
          nameList.Add(studentName);
        }
        else
        {
          Console.WriteLine("That name is already in the list!");
        }
        // Sentinel value loop
      } while (studentName != "q");
*/
      // In class practice:
      // Combine the two programs we've looked at. Prompt for both a name, and a age (between 1 and 100), until the name entered is "exit"
      // Once exited output "$name is $age years old". for each stored person
      // Hint: you'll need multiple arrays
      string personName;
      List<string> peopleName = new List<string>();
      List<int> peopleAge = new List<int>();
      do
      {
        personName = GetName("Please enter the individual's name. Enter \"exit\" to close the program.");
        if (personName.ToLower() != "exit")
        {
          int personAge = GetInt("Please enter the individual's age.");
          peopleName.Add(personName);
          peopleAge.Add(personAge);
        }
      } while (!(personName.ToLower() == "exit"));

      for (int i = 0; i < peopleName.Count; i++)
      {
        Console.WriteLine($"{peopleName[i]} is {peopleAge[i]} years old.");
      }
    }

    /*
     * static: Tells C# to only keep one copy of the method in memory (important for OOP)
     * int: Return type, the type of data coming out of the method.
     * GetInt: Name of the method, how we call it.
     * string: First parameter type, the type of input expected.
     * prompt: First parameter / arguement name, how we refer to that value in the method.  
     */

    static int GetInt(string Prompt)
    {

      int input = 0;
      bool valid = false;
      int min = 1;
      int max = 100;
      
      do
      {
        Console.WriteLine(Prompt);
        try
        {
          input = int.Parse(Console.ReadLine());
          if (input < min || input > max)
          {
            throw new Exception($"The supplied value must be betwen {min} and {max}");
          }
          else
          {
            valid = true;
          }
        }
        catch (Exception e)
        {
          Console.WriteLine($"ERROR: {e.Message}");
        }
        // Validation loop
      } while (!valid);
      return input;
    }

    static string GetName(string Prompt)
    {
      string input;
      Console.WriteLine(Prompt);
      input = Console.ReadLine();
      return input;
    }
  }
  // Exit point of programs in C#.
}
