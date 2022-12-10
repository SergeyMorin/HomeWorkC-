// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Массив из скольки элементов требуется сгенерировать?");
int n = int.Parse(Console.ReadLine()!);

method(n);

void method(int i)
{
int[] array = new int[i];
while(i>0)
{
    array[i - 1] = new Random().Next(0,100);
    i--;
}
Console.Write("[");
for (i = 0; i < array.Length-1; i++)  // вывод в консоль массива по элементам
{
    Console.Write($"{array[i]}, ");
}
Console.Write($"{array[i]}]");
}