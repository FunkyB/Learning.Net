//Напишите программу, в которой пользователь вводит с клавиатуры букву. Программа должна вывести "гласная" если введённая буква гласная.
//Если буква согласная, программа ничего не выводит. Пользователь вводит только русские строчные буквы.
//Sample Input:
//а
//Sample Output:
//гласная
//а, е, ё, и, о, у, ы, э, ю, я

using System;

public class MainClass
{
    public static void Main()
    {
        char letter = Convert.ToChar(Console.ReadLine());

        switch (letter)
        {
            case 'а':
                Console.WriteLine("гласная");
                break;
            case 'е':
                Console.WriteLine("гласная");
                break;
            case 'ё':
                Console.WriteLine("гласная");
                break;
            case 'и':
                Console.WriteLine("гласная");
                break;
            case 'о':
                Console.WriteLine("гласная");
                break;
            case 'у':
                Console.WriteLine("гласная");
                break;
            case 'ы':
                Console.WriteLine("гласная");
                break;
            case 'э':
                Console.WriteLine("гласная");
                break;
            case 'ю':
                Console.WriteLine("гласная");
                break;
            case 'я':
                Console.WriteLine("гласная");
                break;
            default:
                break;
        }
    }
}