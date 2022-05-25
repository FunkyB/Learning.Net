public static class Kata
{
    static void Main()
    {
        Check(new object[] { 66, 101 }, 66);
        Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45);

        Check(new object[] { 't', 'e', 's', 't' }, 'e');
        Check(new object[] { "what", "a", "great", "kata" }, "kat");
    }

    public static bool Check(object[] a, object x)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].Equals(x))
            {
                return true;
            }
        }
        return false;
    }
}