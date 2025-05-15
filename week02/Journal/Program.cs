using System;


// Exceeding Requirement: I ensure that my file is saving and loading as csv file.
public class Program
{

    public static void Main(string[] args)
    {
    Console.WriteLine("Hello World! This is the Journal Project.");
    
    Journal journal = new Journal();
    PromptGenerator promptGenerator = new PromptGenerator();
    
    string choice = "";

    while (choice != "5")
    {
        Console.WriteLine("\nPlease select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        choice = Console.ReadLine();
        

        if (choice == "1" || choice.ToLower() == "write")
        {
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine(prompt);
            Console.Write("Response: ");
            string response = Console.ReadLine();
            Entry entry = new Entry(prompt,response);
            journal.AddEntry(entry);
        }
        else if (choice == "2" || choice.ToLower() == "display")
        {
            journal.DisplayAll();
        }
        else if (choice == "3" || choice.ToLower() == "save")
        {
            Console.Write("Enter filename to save: ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
            
        }
        else if (choice == "4" || choice.ToLower() == "load")
        {
            Console.Write("Enter filename to load: ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
            
        }
        
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
        }


}
