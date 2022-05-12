public static class Kata
{
    static void Main()
    {
        ReverseWords("This is an example!");
    }

    public static void ReverseWords(string str)
    {
        List<string> result = str.Split(' ').ToList();
        for (int i = 0; i < result.Count; i++)
        {
            result[i].Reverse();
        }
    }
}