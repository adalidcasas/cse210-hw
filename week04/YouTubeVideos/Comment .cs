using System.ComponentModel;

public class Comment
{
    private string _fullName;
    private string _text;

    public Comment(string FullName, string Text)
    {
        _fullName = FullName;
        _text = Text;
    }

    public string GetComment()
    {
        return $"{_text}\n      Author: {_fullName}";
    }
}