public static class Kata
{
    static void Main()
    {
        Maskify("4556364607935616");
        Maskify("1");
        Maskify("11111");
    }
    
    public static string Maskify(string cc)
    {
        const int NumberOfDigitsShowing = 4;
        if (cc.Length > 4)
        {
            string visiblePart = cc.Remove(0, cc.Length - NumberOfDigitsShowing);
            cc = new string('#', cc.Length - 4) + visiblePart;
        }
        return cc;
    }
}