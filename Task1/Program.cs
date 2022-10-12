// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите первое число: ");
int numbA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numbB = int.Parse(Console.ReadLine());

int exponentiation = Exponentiation(numbA, numbB);
Console.WriteLine($"Натуральная степень первого числа от второго = {Exponentiation(numbA, numbB)}");

int Exponentiation(int numbA, int numbB)
{
    int result = 1;
    for (int i = 1; i <= numbB; i++)
    {
        result = result * numbA;
    }
    return result;
}