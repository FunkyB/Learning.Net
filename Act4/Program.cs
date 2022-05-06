//Для начала небольшая задачка для разогрева. Напишите программу, которая берет введенный пользователем текст и отображает его вертикально.
//Sample Input:
//Привет
//Sample Output:
//П
//р
//и
//в
//е
//т

using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();

        char[] vs = line.ToCharArray();

        for (int i = 0; i < vs.Length; i++)
        {
            Console.WriteLine(vs[i]);
        }
    }
}