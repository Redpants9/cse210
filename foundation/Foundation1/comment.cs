public class Comment{
    private string _commenter;
    private string _comment;

    public string display()
    {
        return $"{_commenter}:{_comment}";
    }
    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public bool addComment(string commenter, string comment)
    {
        this._comment = comment;
        this._commenter = commenter;
        return true;
    }
}