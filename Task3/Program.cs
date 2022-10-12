// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

void PrintArray() // выводим на экран массив из 8 элементов
{
    Console.WriteLine();
    int[] array = new int[8];
    FillArray(array);
    Console.WriteLine();
}

void FillArray(int[] array) // заполняем массив рандомными цифрами от 0 до 10
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write($" [{array[i]}] ");
    }
}
PrintArray();