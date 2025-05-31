using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comment = new List<Comment>();
    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author =author;
        _length  = length;
        
    }
    public string GetTitle()
    {
        return _title;
    }
    private void SetTitle(string title)
    {
        _title = title;
    }
     public string GetAuthor()
    {
        return _author;
    }
    private void SetAuthor(string author)
    {
        _author = author;
    }
    
     public int GetLength()
    {
        return _length;
    }
    private void SetLength(int length)
    {
        _length = length;
    }
    
    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }
    public int GetNumberOfComment()
    {
        return _comment.Count;
    }
    
    public List<Comment> GetComments()
    {
        return _comment;
    }
}