using System.IO.Pipes;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string Title, string Author, int Length)
    {
        _author = Author;
        _title = Title;
        _length = Length;
    }

    private int GetQuantityOfComments()
    {
        int quantity = _comments.Count();
        return quantity;
    }

    public void SetComment(Comment MyComment)
    {
        _comments.Add(MyComment);
    }

    private string GetEnumerateCommentList()
    {
        string enumerateList = "";
        int numeroOfComment = 0;
        foreach (Comment MyComment in _comments)
        {
            numeroOfComment += 1;
            enumerateList += "      " + numeroOfComment.ToString() + " " + MyComment.GetComment() + "\n";
        }
        return enumerateList;
    }

    public string GetVideoDescription()
    {
        return $"Title: {_title}\n" +
                $"Author: {_author}\n" +
                $"Duration: {_length} sec.\n" +
                $"Quantity of comments: {GetQuantityOfComments()}\n" +
                $"{GetEnumerateCommentList()}";
    }
}