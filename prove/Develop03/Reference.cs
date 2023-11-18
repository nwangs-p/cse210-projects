public class Reference
{
    private string _referenceText;

    public Reference(string referenceText)
    {
        _referenceText = referenceText;
    }

    public string GetDisplay()
    {
        return _referenceText;
    }
}
