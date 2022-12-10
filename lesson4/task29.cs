// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Массив из скольки элементов требуется сгенерировать? ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Чему равен минимальный элемент массива? ");
int mininput = int.Parse(Console.ReadLine()!);
Console.Write("Чему равен максимальный элемент массива? ");
int maxinput = int.Parse(Console.ReadLine()!);

method(n, mininput, maxinput);

void method(int i, int min, int max)
{
int[] array = new int[i];
while(i>0)
{
    array[i - 1] = new Random().Next(min,max+1);
    i--;
}
Console.Write("[");
for (i = 0; i < array.Length-1; i++)  // вывод в консоль массива по элементам
{
    Console.Write($"{array[i]}, ");
}
Console.Write($"{array[i]}]");
}