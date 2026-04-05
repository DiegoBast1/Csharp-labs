

using System;

class Program
{
    static void Main()
    {
        //creating two strings and concatenating them.
        string myFirstString = "Hello, this is";
        string mySecondString = " Diego";
        string concatenatedString = myFirstString + mySecondString;

        Console.WriteLine(concatenatedString);
        Console.WriteLine("concatenated string length: " + concatenatedString.Length); //displaying length
        Console.WriteLine(concatenatedString.ToLower()); //changing string to lowercase
        Console.WriteLine(); //new line

        //adding two integer variables
        int integer1 = 100;
        int integer2 = 25;
        
        Console.WriteLine("The two integers used: " + integer1 + " and " + integer2);
        Console.WriteLine("Sum of the two integers: " + (integer1 + integer2)); //sum
        Console.WriteLine("Difference of the two integers: " + (integer1 - integer2)); //difference
        Console.WriteLine("Product of the two integers: " + (integer1 * integer2)); //product
        Console.WriteLine("Result of the division of the two integers: " + (integer1 / integer2)); //result of dividing
        Console.WriteLine(); //newline
        
        //user input + converting it to integer
         Console.Write("Enter a number of your choice: ");
        int userChosenNumber = int.Parse(Console.ReadLine());
                                                                    //10: sum of year 2026 digits
        int result = (7 * userChosenNumber) - (5 * userChosenNumber) + 10;    
        Console.WriteLine("result of operation " + result);
        Console.WriteLine(); //newline

        //sports I like.
        Console.WriteLine("Sports I like: ");
        Console.WriteLine("Curling\n" +
                          "Swimming\n" +
                          "Basketball\n" +
                          "Cycling\n");
        Console.WriteLine(); //newline

        //assigning values to two new string variables
        string redCars = "red cars";
        string blueCars = "blue cars";

        Console.WriteLine($"I don't like {redCars} but I do like {blueCars}");
    }
}