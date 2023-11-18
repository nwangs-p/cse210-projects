public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public string Text => _hidden ? "_____" : _text;

    public bool Hidden => _hidden;

    public void Hide()
    {
        _hidden = true;
    }
}

