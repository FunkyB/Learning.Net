namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DifferenceParam = "-";
            const bool ToString = true;
            int userInput = 0;
            int firstInputParam = CollectUserInput(userInput);
            int secondInputParam = CollectUserInput(userInput);
            int thirdInputParam = CollectUserInput(userInput);

            Console.WriteLine($"Принимает 3 целочисленные переменные и выводит на экран результат их сложения: ");
            Console.WriteLine($"{PrintResult(firstInputParam, secondInputParam, thirdInputParam)}");

            Console.WriteLine($"Принимает 3 целочисленные переменные и выводит на экран результат их разности: ");
            Console.WriteLine($"{PrintResult(firstInputParam, secondInputParam, thirdInputParam, DifferenceParam)}");

            Console.WriteLine($"Принимает 2 целочисленные переменные и выводит первое число в степени второго: ");
            Console.WriteLine($"{PrintResult(firstInputParam, secondInputParam)}");

            Console.WriteLine($"Принимает 3 целочисленные переменные и вводит на экран сумму значений этих переменных представленных в строковом виде ");
            Console.WriteLine($"{PrintResult(firstInputParam, secondInputParam, thirdInputParam, ToString)}");
        }

        static int CollectUserInput(int userInput)
        {
            Console.WriteLine("Введите число");
            userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        static int PrintResult(int firstInputParam, int secondInputParam, int thirdInputParam)
        {
            int result = firstInputParam + secondInputParam + thirdInputParam;
            return result;
        }

        static int PrintResult(int firstInputParam, int secondInputParam, int thirdInputParam, string DifferenceParam)
        {
            int result = firstInputParam - secondInputParam - thirdInputParam;
            return result;
        }
        static double PrintResult(int firstInputParam, int secondInputParam)
        {
            double result = Math.Pow(firstInputParam, secondInputParam);
            return result;
        }
        static string PrintResult(int firstInputParam, int secondInputParam, int thirdInputParam, bool ToString)
        {
            int countResult = firstInputParam + secondInputParam + thirdInputParam;
            string stringResult = $"«{firstInputParam}» + «{secondInputParam}» + «{thirdInputParam}» = «{countResult}»";
            return stringResult;
        }
    }
}