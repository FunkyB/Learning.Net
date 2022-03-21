namespace MethodParams
{
    class Program
    {
        static void Main(string[] args)
        {
            const string TrueParam = "Да";
            const string FalseParam = "Нет";

            Console.Write("Введите 3 целых числа: ");
            int userInput = 0;
            int firstInputParam = CollectUserInput(userInput);
            int secondInputParam = CollectUserInput(userInput);
            int thirdInputParam = CollectUserInput(userInput);
            bool additionalParam = true;
            Console.WriteLine($"Введите значение дополинтельного параметра, допустимые значения: {TrueParam} или {FalseParam}");
            string? additionalInputParam = Console.ReadLine();
            switch (additionalInputParam)
            {
                case TrueParam:
                    additionalParam = true;
                    break;
                case FalseParam:
                    additionalParam = false;
                    break;
                default:
                    Console.WriteLine("Неправильное значение дополнительного параметра");
                    break;
            }

            Console.WriteLine($"Результат выполнения метода №3: {ResultMethod(firstInputParam, secondInputParam, thirdInputParam, additionalParam)}");
            Console.WriteLine($"Значения параметров: первое число - {firstInputParam}, второе число - {secondInputParam}, третье число - {thirdInputParam}, логический параметр - {additionalParam}");
        }
        static int CollectUserInput(int userInput)
        {
            Console.WriteLine("Введите число");
            userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        static int SummUserInput(int firstInputParam, int secondInputParam, int thirdInputParam)
        {
            int sum = firstInputParam + secondInputParam + thirdInputParam;
            return sum;
        }

        static int RefIncrementSumm(ref int firstInputParam, int secondInputParam, int thirdInputParam)
        {
            firstInputParam++;
            secondInputParam++;
            thirdInputParam++;
            int sum = firstInputParam + secondInputParam + thirdInputParam;
            return sum;
        }

        static int ResultMethod(int firstInputParam, int secondInputParam, int thirdInputParam, bool additionalParam)
        {
            int result = additionalParam == true
                ? SummUserInput(firstInputParam, secondInputParam, thirdInputParam)
                : RefIncrementSumm(ref firstInputParam, secondInputParam, thirdInputParam);
            return result;
        }
    }
}