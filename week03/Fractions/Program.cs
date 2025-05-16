using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
      // For balance variable;
       /* Account saving =  new Account();
        saving._balance = 50;
        saving.Deposit(100);
        */
        
        
        // For transaction list;
        /*
        Account saving = new Account();
        saving.Deposit(200);
        saving.Deposit(500);
        
        saving.DisplayTransaction();
        */
        
        
        //Encapulation starts here
        
        
        
        /*
        Account saving = new Account();
        
        saving.SetBalance(200);
        saving.Deposit(500);
        */
        
        
       /* Account saving = new Account();
        saving.Deposit1(1000);
        saving.Deposit1(2000);
        saving.GetBalance();
        */
        
       /* 
        Person person = new Person();
        
        person.SetTitle("Mr.");
        person.SetFirstName("Oluchukwu");
        person.SetLastName("Offor");
        
        Console.WriteLine(person.GetInformalSignature());
        Console.WriteLine(person.GetFormalSignature());
        */
        
        Fraction f = new Fraction();
        Fraction f1 = new Fraction(1);
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3,4);
        Fraction f4 = new Fraction(1,3);
        
    //    Console.WriteLine(f.GetFractionString());
    //    Console.WriteLine(f.GetDecimalValue());
       
       Console.WriteLine(f1.GetFractionString());
       Console.WriteLine(f1.GetDecimalValue());
       
       Console.WriteLine(f2.GetFractionString());
       Console.WriteLine(f2.GetDecimalValue());
       
       Console.WriteLine(f3.GetFractionString());
       Console.WriteLine(f3.GetDecimalValue());
       
       Console.WriteLine(f4.GetFractionString());
       Console.WriteLine(f4.GetDecimalValue());
    }
}