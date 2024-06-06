public class Exercise
{
    public int Total { get; set; } = 0;
    public int Current { get; set; } = 0;
    public List<string> Word { get; set; }
    public Exercise(List<string> Words)
    {
        this.Word = Words;
        for (int i = 0; i < Word.Count; i++)
        {
            CalculateFirst(Word, i);
            CalculateSecond(Word, i);
            Total += Current;
        }
        System.Console.WriteLine(Total);
    }

    public void CalculateFirst(List<string> Words, int n)
    {
        Current = 0;
        for (int i = 0; i < Words[n].Length; i++)
        {
            if (Char.IsDigit(Word[n], i))
            {
                Current += (Word[n][i] - '0') * 10;
                System.Console.WriteLine(Current);
                break;
            }
        }
    }
    public void CalculateSecond(List<string> Words, int n)
    {
        for (int i = Words[n].Length - 1; i >= 0; i--)
        {
            if (Char.IsDigit(Words[n], i))
            {
                Current += Word[n][i] - '0';
                System.Console.WriteLine(Current);
                break;
            }
        }
    }


}
