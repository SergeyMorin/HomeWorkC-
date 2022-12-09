// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число, сумму цифр которого необходимо посчитать: ");
int num = int.Parse(Console.ReadLine()!); // ввод числа

Console.Write("Cумма цифр числа {0} равна {1} .", num, sumnumber(num)); 

int sumnumber(int number)
{
if (number < 0) // на случай если ввели отрицательное число)
{
number = Math.Abs(number);
}

int temp = number;
int i = 1;

while (number >= 10) // определение количества разрядов в числе
{
    number = number / 10;
    i++;
}

int[] array = new int[i]; // создание массива по количеству разрядов заданного числа

while (i > 0) // заполнение массива по разрядам 
{
    array[i - 1] = temp % 10;
    temp = temp / 10;
    i--;
}

int sum = 0; // ввод переменой для сумирования элементотв

for (i = 0; i < array.Length; i++) // суммирование элементов массива
{
    sum = sum + array[i];
}
return sum;
}