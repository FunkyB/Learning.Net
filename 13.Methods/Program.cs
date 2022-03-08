Console.WriteLine("Введите кол-во сотрудников");
int totalWorkers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите стоимость 1ого труд дня");
decimal dailySalary = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите количество рабочих дней");
int paidDays = Convert.ToInt32(Console.ReadLine());

static decimal CountSalaryOfOneWorker(decimal dailySalary, int paidDays)
{
    decimal salaryOfOneWorker = dailySalary * paidDays;
    return salaryOfOneWorker;
}

static decimal CountTotalPayment(int totalWorkers, decimal dailySalary, int paidDays)
{
    decimal totalPayment = totalWorkers * CountSalaryOfOneWorker(dailySalary, paidDays);
    return totalPayment;
}

decimal totalPayment = CountTotalPayment(totalWorkers, dailySalary, paidDays);
Console.WriteLine($"Общий объем денег, необходимый для оплаты зарплаты введенному пользователем количеству сотрудников: {totalPayment}");