public static class Kata
{
    static void Main()
    {
        SumMix(new object[] { 9, 3, "7", "3" });
        SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 });
        SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" });
    }

    public static int SumMix(object[] x)
    {
        int sum = 0;
        for (int i = 0; i < x.Length; i++)
        {
            sum += Convert.ToInt32(x[i]);
        }
        return sum;
    }
}