public static class Kata
{
    static void Main()
    {
        ReverseWords("This is an example!");
    }

    public static string ReverseWords(string str)
    {
        return string.Join(" ", str.Split(' ').Select(x => new String(x.Reverse().ToArray())));
    }
}