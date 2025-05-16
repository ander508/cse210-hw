public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;
    
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    
    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }
    public string GetFirstName()
    {
        return _firstName;
    }
    
    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }
    public string GetLastName()
    {
        return _lastName;
    }
    
    public string GetInformalSignature()
    {
        return "Thanks, " + GetFirstName()+ ".";
    }
    
    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullname() + ".";
    }
    
    public string GetFullname()
    {
        return GetTitle() + " " + GetFirstName() + " " + GetLastName();
        // return GetTitle() + " " + GetFirstName() + " " + GetFullname();
    }
}