Console.WriteLine("Введите число");
bool intX = int.TryParse(Console.ReadLine(), out int x);
if (!intX)
{
    Console.WriteLine("Введено не челое число");
    return;
}
do
{
    Console.WriteLine(--x);
}
while (x > 0);