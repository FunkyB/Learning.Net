using System.Numerics;

namespace _017.FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            BigInteger number = CollectUserInput(userInput);
            int secondInputParam = CollectUserInput(userInput);
            int thirdInputParam = CollectUserInput(userInput);
        }

        static int CollectUserInput(int userInput)
        {
            Console.WriteLine("Введите число");
            userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }


    }
}