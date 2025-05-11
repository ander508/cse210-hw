using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        
        // Person person = new Person();
        
        // person._familyName = "Offor";
        // person._givenName = "Oluchukwu";
        
        // Console.WriteLine(person._familyName);
        // Console.WriteLine(person._givenName);
        
        // person.ShowEasternName();
        // person.ShowWesternnName();
        
        
    //     Blind kitchen = new Blind();
    //     kitchen._height = 60;
    //     kitchen._width = 48;
    //     kitchen._color = "White";
        
    //     Console.WriteLine($"Kitchen Height is: {kitchen._height}");
        
    //     double kitchenArea = kitchen.GetArea();
    //     Console.WriteLine($"Area of Kitchen is {kitchenArea}");
        
        
    //     Blind livingRoom = new Blind();
    //     livingRoom._height = 72;
    //     livingRoom._width = 52;
    //     livingRoom._color = "White";
        
    //    double livingRoomArea = livingRoom.GetArea();
    //     Console.WriteLine($"Area of LivingRoom is {livingRoomArea}");
        
        
    //     House andersonHouse =  new House();
        
    //     andersonHouse._kitchen = new Blind();
    //     andersonHouse._livingRoom = new Blind();
    //     andersonHouse._owner = "Anderson";
        
    //     andersonHouse._kitchen._height = 100;
    //     andersonHouse._kitchen._color = "White";
    //     andersonHouse._kitchen._width = 70;
    //     double andersonKitchenArea = andersonHouse._kitchen.GetArea();
    //     Console.WriteLine($"Area of Anderson Kitchen is {andersonKitchenArea}");
        
        
    //     andersonHouse._livingRoom._height = 200;
    //     andersonHouse._livingRoom._width = 120;
    //     andersonHouse._livingRoom._color = "Cream";
    //     double andersonLivingRoom = andersonHouse._livingRoom.GetArea();
    //     Console.WriteLine($"Area of Anderson LivingRoom is {andersonLivingRoom}");
        
        
        Console.WriteLine("");
        
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // Console.WriteLine(job1._company);
        job1.DisplayJob();
        
        
        
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        // Console.WriteLine(job2._company);
        job2.DisplayJob();
        
        
        Console.WriteLine("");
        
        
        
        
        // Resume section
        Resume resume1 = new Resume();
        
        resume1._job.Add(job1);
        resume1._job.Add(job2);
        Console.WriteLine(resume1._job[0]._jobTitle);
        Console.WriteLine(resume1._job[1]._jobTitle);
        Console.WriteLine("");
        
        
        resume1._name = "Oluchukwu Offor";
        resume1.Display();
        Console.WriteLine("");
        
    }
}