//Дяде Васе позвонили из "службы безопасности банка" и попросили назвать номер карты.
//Сомневаясь в истинности этого звонка, он решил назвать номер в обратном порядке.
//Но дядя Вася не был бы дядей Васей, если бы на его карте не отсутствовали первые две цифры.
//Помогите ему сохранить сбережения и на место отсутствующих первой и второй цифр поставьте значения минимальной и максимальной цифры в номере соответственно,
//затем весь номер переверните.

//Sample Input:
//95358420661899
//Sample Output:
//9981660248535990

using System;
using System.Linq;

public class MainClass
{
    public static void Main()
    {
        string cardNumber = Console.ReadLine();
        int[] cardDigits = new int[cardNumber.Length];
        for (int i = 0; i < cardNumber.Length; i++)
        {
            cardDigits[i] = int.Parse(cardNumber[i].ToString());
        }
        var fullCardNumber = new int[cardNumber.Length + 2];
        Array.Copy(cardDigits, 0, fullCardNumber, 2, cardNumber.Length);
        fullCardNumber[0] = cardDigits.Min();
        fullCardNumber[1] = cardDigits.Max();
        Array.Reverse(fullCardNumber);
        Console.WriteLine(string.Join("", fullCardNumber));
    }
}