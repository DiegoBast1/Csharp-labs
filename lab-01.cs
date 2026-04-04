
//using system to avoid using it in every statement, also downloaded .NET to run C#.

using System;
using System.Net.WebSockets;

class Program
{
    static void Main()
    {
        //ouputing my name
        Console.WriteLine("Diego");

        // creating int variable
        int myNumber = 25;
        Console.WriteLine("my integer variable = " + myNumber);
        Console.WriteLine(); //new line

        // creating double variable
        double myDoubleVariable = 25.1;
        Console.WriteLine("my double variable = " + myDoubleVariable);
        Console.WriteLine(); //new line

        // creating string and char variables
        string myString = "Hello World";
        char myCharVariable = 'D';
        Console.WriteLine("string variable = " + myString);
        Console.WriteLine("char variable = " + myCharVariable);
        Console.WriteLine(); //new line

        // creating boolean variable
        bool theCarIsRed = true;
        Console.WriteLine("Is the car red? = " + theCarIsRed);
        Console.WriteLine(); //new line

        // difference between Console.WriteLine(); and Console.Write();
        Console.WriteLine("Best");
        Console.WriteLine("Regards");
        Console.WriteLine(); //new line

        Console.Write("Best");
        Console.Write("Regards");
        Console.WriteLine(); //new line

        /*

        - The main difference between Console.Write() and Console.WriteLine(),
         is that Console.Write() print the text but doesn't print a new line. If we use
         various Console.Write() text statements the output will be set together, if we use
         the Console.WriteLine() statements instead, a new line will be printed after every statement. 
        
        */

        // C# Syntax Error Explanation.
        /*

         ConsoLe.WriteLine("Welcome to IT1050!");
         console.WriteLine("Programming Logic");
         Console.Writeline("Spring 2026 semester");
         Console.WriteLine("We are learning C#);

         After running the program, a message saying "failed to build"
         appeared on the screen. The program didn't compile.

         Every Console.WriteLine() statement has an issue:

         1st statement: incorrect capitalization, "L" in ConsoLe, must be lowercase.
         2nd statement: incorrect capitalization again, "c" in console must be uppercase.
         3rd statment: incorrect capitalization, "l" in Writeline must be uppercase.
         4th statement: missing double quote at the end of the string.

        */

        // Corrected statements:

        Console.WriteLine("Welcome to IT1050!");
        Console.WriteLine("Programming Logic");
        Console.WriteLine("Spring 2026 semester");
        Console.WriteLine("We are learning C#");
    }


}