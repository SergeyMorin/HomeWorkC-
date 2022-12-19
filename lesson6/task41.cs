// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Сколько чисел требуется ввести? ");
int userInput = int.Parse(Console.ReadLine()!);
Console.Write(Method(userInput));
int Method(int size)
{
    int[] array = new int[size];
    int counterOfPositiveNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine()!);
        if (array[i] > 0)
            counterOfPositiveNumbers++;
    }
    Console.Write("Введено положительных чисел: ");
    return counterOfPositiveNumbers;
}