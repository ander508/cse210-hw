public class Comment
{
    public string _name;
    public string _commentText;
    
    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText= commentText;
    }
    
    public string GetCommenterName()
    {
        return _name;
    }
    public void SetCommenterName(string name)
    {
        _name = name;
    }
    
    public string GetCommentText()
    {
        return _commentText;
    }
    public void SetCommentText(string commentText)
    {
        _commentText = commentText;
    }
    
}