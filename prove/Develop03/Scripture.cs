public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public bool AllWordsHidden => _words.All(word => word.Hidden);

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplay()}\n\n{_words.Select(word => word.Text).Aggregate((current, next) => $"{current} {next}")}";
    }

    public void HideRandomWords()
    {
        int wordsToHide = _random.Next(1, 4); // Hide 1 to 3 words randomly

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = _random.Next(0, _words.Count);
            _words[randomIndex].Hide();
        }
    }
}

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John 3:16"), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("2 Nephi 9;1"), "And now, my beloved brethren, I have read these things that ye might know concerning the acovenants of the Lord that he has covenanted with all the house of Israel,"),
            new Scripture(new Reference("2 Nephi 5:4"), "Now I do not write upon these plates all the words which they murmured against me. But it sufficeth me to say, that they did seek to take away my life."),
            new Scripture(new Reference("proverbs 31:3"), "Give not thy strength unto women, nor thy ways to that which destroyeth kings."),
            new Scripture(new Reference("Genesis 1:27"), "So God created mankind in his own image,  in the image of God he created them;     male and female he created them."),
        };
        _random = new Random();
    }

    public Scripture GetRandomScripture()
    {
        int randomIndex = _random.Next(0, _scriptures.Count);
        return _scriptures[randomIndex];
    }
}