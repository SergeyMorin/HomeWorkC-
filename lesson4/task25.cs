// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число, которое возводим в степень: А = ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("В какую степень необходимо возвести число А: B = ");
int numberB = int.Parse(Console.ReadLine()!);

Console.Write("число {0} в степени {1} равно {2}.", numberA, numberB, MathPower(numberA, numberB));

int MathPower(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}