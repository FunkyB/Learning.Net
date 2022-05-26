//Метод GetTypeInfo должен возвращать строку с информацией о типе переданной в него переменной:
//"Переменная является строкой"
//"Переменная целочисленного типа"
//"Переменная - число с плавающей точкой"
//"Переменная является символом"

//public static void Main()
//{
//    string str = Console.ReadLine();
//    int a = int.Parse(str);
//    double b = (double)a;
//    char c = str[0];
//    Console.WriteLine(GetTypeInfo(str));
//    Console.WriteLine(GetTypeInfo(a));
//    Console.WriteLine(GetTypeInfo(b));
//    Console.WriteLine(GetTypeInfo(c));
//}
//Sample Input:
//123
//Sample Output:
//Переменная является строкой
//Переменная целочисленного типа
//Переменная - число с плавающей точкой
//Переменная является символом

class Program

{
    public static void Main()
    {
        string str = Console.ReadLine();
        int a = int.Parse(str);
        double b = (double)a;
        char c = str[0];
        Console.WriteLine(GetTypeInfo(str));
        Console.WriteLine(GetTypeInfo(a));
        Console.WriteLine(GetTypeInfo(b));
        Console.WriteLine(GetTypeInfo(c));
    }
    public static string GetTypeInfo(string input) => "Переменная является строкой";

    public static string GetTypeInfo(int input) => "Переменная целочисленного типа";

    public static string GetTypeInfo(double input) => "Переменная - число с плавающей точкой";

    public static string GetTypeInfo(char input) => "Переменная является символом";
}