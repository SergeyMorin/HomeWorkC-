// Задача 1. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

/*

Console.WriteLine("Введите первое число ");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

Console.WriteLine("Введите второе число ");
string num2 = Console.ReadLine()!;
int num2int = int.Parse(num2);

if (num1int > num2int)
{
    Console.WriteLine(num1int + " Больше " + num2int);
}

else if (num2int > num1int)
{
    Console.WriteLine(num2int + " Больше " + num1int);
}

else 
{
Console.WriteLine("числа равны");
}

*/

// Задача 2. Запишите програму которая принимает на вход три числа и выдает максимальное из этих чисел.

/*

Console.WriteLine("Введите первое число ");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

Console.WriteLine("Введите второе число ");
string num2 = Console.ReadLine()!;
int num2int = int.Parse(num2);

Console.WriteLine("Введите третье число ");
string num3 = Console.ReadLine()!;
int num3int = int.Parse(num3);

if (num1int > num2int)
{
    if (num1int > num3int)
    {
        Console.WriteLine(num1int + " самое большое число ");
    }
    else
    {
        Console.WriteLine(num3int + " самое большое число ");
    }
}
else
{
    if (num2int > num3int)
    {
        Console.WriteLine(num2int + " самое большое число ");
    }
    else
    {
        Console.WriteLine(num3int + " самое большое число ");
    }
}

*/

// Задача 3. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

/*

Console.WriteLine("Введите целое число ");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

if (num1int % 2 == 0)
{
    Console.WriteLine(num1int + " число четное ");
}
else
{
    Console.WriteLine(num1int + " число не четное ");
}

*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

/*

Console.WriteLine("Введите целое число больше нуля");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

for (int i = 1 ; i <= num1int ; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " число четное");
    }
    
}

*/