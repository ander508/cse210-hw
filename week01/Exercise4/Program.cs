using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        // List<string> fruits = new List<string>();
        // fruits.Add("Mango");
        // fruits.Add("Apple");
        // fruits.Add("Orange");
        
        // foreach (string fruit in fruits)
        // {
        // Console.WriteLine(fruit);
            
        // }
        
        // Console.WriteLine(fruits.Count);
        
        
        
        // for (int i = 0; i < fruits.Count; i++){
        //     Console.WriteLine(fruits[i]);
        // }
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = 1;
        List<int> values = new List<int>();
        
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            
            if (number != 0)
            {
                values.Add(number);
            }
        }
        
        int sum  = 0;
        foreach (int value in values){
            sum += value;
        }
        int length = values.Count;
        double avg = (float)sum /length;
        int max  = values.Max();
        Console.WriteLine($"Numbers you entered are {string.Join(",", values)}");
        values.Sort();
        Console.WriteLine($"Your sorted list is: {string.Join(",", values)}");
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg:F2}");
        Console.WriteLine($"The largest number is: {max}");
    }
    }