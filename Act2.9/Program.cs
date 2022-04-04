//И вновь дядя Вася берется за измерения, но на этот раз он решил измерить свой дачный участок своей старой рулеткой 5м, пытаясь найти площадь.
//Участок имеет форму прямоугольника.
//Напишите программу, которая вычисляет площадь участка.
//Напоминаем, что у рулетки отломаны первые 20 см и дядя Вася об этом не знает (он напишет 1.2 м, хотя в реальности измерил 1 м).
//А так как длина рулетки меньше стороны участка, то дядя Вася каждый раз, когда заканчивается длина рулетки, ставит зарубку на ограде и,
//переставляя рулетку, продолжает измерения от зарубки.
//Sample Input:
//28 31
//Sample Output:
//Введите два числа через пробел: длина и ширина участка
//Площадь участка: 793.28

using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите два числа через пробел: длина и ширина участка");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        double length = Convert.ToDouble(splitString[0]); // длина
        double width = Convert.ToDouble(splitString[1]); // ширина
        double landArea = 0;                             // переменная для площади

        length -= Math.Ceiling(length / 5) * 0.2;
        width -= Math.Ceiling(width / 5) * 0.2;
        Console.WriteLine($"Данные: {length}, {width}");
        landArea = length * width;

        Console.WriteLine($"Площадь участка: {Math.Round(landArea,2)}");
    }
}