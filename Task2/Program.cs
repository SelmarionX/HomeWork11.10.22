// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {SumNumbers(number)}");

int SumNumbers(int x)
{
    int sum = 0;
    for (int i = 10; i >= 0; i--)
    {
        sum += x / (int)Math.Pow(10.0, i);
        x = x % (int)Math.Pow(10.0, i);
    }
    return sum;
}

