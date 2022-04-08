public class Kata
{
    static void Main()
    {
        Digitize(35231);
        //AbbrevName("Patrick Feenan");
    }

    public static string Digitize(long n)
    {
        string stringInput = Convert.ToString(n);
        string[] test = stringInput.Split(stringInput.Length);
        test.Reverse();

        long[] LongNum = new long[test.Length];
        for (int i = 0; i < test.Length; i++)
        {
            numberArray[i] = no.Substring(counter, 1)
            LongNum[i] = test[i];
        }
        Console.WriteLine(LongNum.ToString());
        //long l = test;

        return "";
    }
}