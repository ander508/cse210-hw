public class Person
{
    public string _givenName;
    public string _familyName;
    
    
    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }
    
    public void ShowWesternnName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}