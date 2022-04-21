public static class Kata
{
    static void Main()
    {
        IsNarcissistic(548834);
        IsNarcissistic(1741725);
        IsNarcissistic(4210818);
        IsNarcissistic(9800817);
        IsNarcissistic(9926315);
    }

    public static bool IsNarcissistic(long n)
    {
        int numberOfDigits = n.ToString().Length;
        char [] intArray = n.ToString().ToCharArray();
        int result = 0;
        for (int i = 0; i < numberOfDigits; i++)
        {
            
            result += Convert.ToInt32(intArray[i]) * numberOfDigits;

            if (result == n)
            {
                return true;
            }
        }
        return false;
    }
}