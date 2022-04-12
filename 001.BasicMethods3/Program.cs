public class Kata
{
    static void Main()
    {
        AbbrevName("Sam Harris");
        //AbbrevName("Patrick Feenan");
    }
    public static string AbbrevName(string name)
    {
        string[] stringArray = name.Split(' ');
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = stringArray[i].ToString().Substring(0, 1);
        }
        return string.Join(".", stringArray).ToUpper();
    }
}