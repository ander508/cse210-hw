using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        
        
        // static int  sum(int x, int y)
        // {
        //     int total = x + y;
        //     return total;
        // }
        // int result = sum(5,3);
        // Console.Write(result);
        
        
        
        DisplayWelcome();
        
        string result = PromptUserName();
        // Console.WriteLine($"Your Username is: {result}");
        
        int answer = PromptUserNumber();
        // Console.WriteLine($"Your Favorite number is: {answer}");
        
        int returnValue = SquareNumber(answer);
        // Console.WriteLine($"The Square of the number is: {returnValue}");
        
        DisplayResult(result, answer);
        
        
        
    }
        
        
        //1. DisplayWelcome Function
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        
        
        
        //2. PromptUserName function
        static string PromptUserName()
        {
            Console.Write("What is your username? ");
            string username = Console.ReadLine();
            return username;
        }
       
        
        
        
        
        //3. PromptUserNumber function
        static int PromptUserNumber()
        {
            Console.Write("Enter you favorite number! ");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            return num;
        }
       
        
        
        
        
        //4. SquareNumber
        static int SquareNumber(int x)
        {
            int square = x * x;
            return square;
        }
        
        
        
        //5. DisplayResult
        static void DisplayResult(string username, int x)
        {
            Console.WriteLine($"{username}, the square of your number is {x * x}");
        }
    }
    
