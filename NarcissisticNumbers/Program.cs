public static class Kata
{
    static void Main()
    {
        IsNarcissistic(435);
        IsNarcissistic(1741725);
        IsNarcissistic(4210818);
        IsNarcissistic(9800817);
        IsNarcissistic(9926315);
    }

    public static bool IsNarcissistic(long n)
    {
        int numberOfDigits = n.ToString().Length;
        string input = n.ToString();
        int[] intArray = new int[input.Length];
        double result = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = int.Parse(input[i].ToString());
            result += Math.Pow(Convert.ToInt32(intArray[i]), numberOfDigits);

            if (result == n)
            {
                return true;
            }
        }
        return false;
    }
}