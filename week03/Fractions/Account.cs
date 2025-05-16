using System.Formats.Asn1;

public class Account
{
    /*public int _balance;
    
    public void Deposit(int amount)
    {
        _balance = _balance + amount;
        Console.WriteLine(_balance);
    }
    */
    
    /*
    public List<int> _transaction = new List<int>();
    public void Deposit(int amount)
    {
        _transaction.Add(amount);
    }
    public void DisplayTransaction()
    {
        foreach (int transaction in _transaction)
        {
            Console.WriteLine(transaction);
        }
    }
    */
    


//Applying Encapsulation on the above exampleis next.

/*
private int _balance;

public void SetBalance(int balance)
{
    _balance = balance;
    
}
public int GetBalance()
{
    return _balance;
}

public void Deposit(int amount)
{
    _balance = GetBalance() + amount;
    Console.WriteLine(_balance);
}

*/

    private List<int> _transaction = new List<int>();
    
    public void SetBalance(int amount)
    {
        
    }
    
    
    public void Deposit1(int amount)
    {
        _transaction.Add(amount);
    }
    public void GetBalance()
    {
        foreach (int transaction in _transaction)
        {
            Console.WriteLine(transaction);
        }
    }
    

}