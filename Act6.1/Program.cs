//Программа должна выводить в консоль строку, состоящую из amount количества символов symbol. Напишите метод Print.
//public static void Main()
//{
//    string symbol = Console.ReadLine();
//    string amount = Console.ReadLine();
//    Print(symbol, amount, out string result);
//    Console.WriteLine(result);
//}
//Sample Input:
//A
//5
//Sample Output:
//AAAAA

class Program

{
    public static void Main()
    {
        string symbol = Console.ReadLine();
        string amount = Console.ReadLine();
        Print(symbol, amount, out string result);
        Console.WriteLine(result);
    }

    private static string Print (string symbol, string amount, out string result)
    {
        return result = new string(Convert.ToChar(symbol), Convert.ToInt32(amount));
    }

}