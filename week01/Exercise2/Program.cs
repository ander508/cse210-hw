using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        
        // Console.Write("What is your favorite number? ");
        // string userInput = Console.ReadLine();
        // int number = int.Parse(userInput);
        
        // Console.WriteLine(number);
        
        // Console.Write("Enter a number? ");
        // string num = Console.ReadLine();
        // int x = int.Parse(num);
        // int y = 20;
        
        // if (x > y)
        // {
        //     Console.WriteLine("Greater");
        // }
        // else if (x < y)
        // {
        //     Console.WriteLine("Less");
        // }
        // else {
        //     Console.WriteLine("Equal");
        // }
        
        
        Console.Write("Enter grade? ");
        string gradeEnteredByUser = Console.ReadLine();
        int grade = int.Parse(gradeEnteredByUser);
        string letter;
        
        if (grade >= 90)
        {
           
            if ((grade - 90) < 3)
            {
            letter = "A-";
                
            }
            else{
            letter = "A";
                
            }
        }
        else if (grade >= 80)
        {
            if ((grade - 80) >= 7)
            {
            letter = "B+";
                
            }
            else if ((grade - 80) < 3)
            {
            letter = "B-";
                
            }
            else{
            letter = "B";
                
            }
        }
        else if (grade >= 70)
        {
             if ((grade - 70) >= 7)
            {
            letter = "C+";
                
            }
            else if ((grade - 70) < 3)
            {
            letter = "C-";
                
            }
            else{
            letter = "C";
                
            }
        }
        else if (grade >= 60)
        {
            if ((grade - 60) >= 7)
            {
            letter = "D+";
                
            }
            else if ((grade - 60) < 3)
            {
            letter = "D-";
                
            }
            else{
            letter = "D";
                
            }
        }
        else{
           letter = "F";
            
        }
        
        Console.WriteLine($"Grade: {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation you passed.");
            
        }
        else
        {
            Console.WriteLine("Success awaits you, try Again.");
            
        }
        
        
    
    }
}