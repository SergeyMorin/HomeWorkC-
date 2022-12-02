// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите положительное пятизначное число.");
string num = Console.ReadLine()!;

char[] array1 = {num[0],num[1],num[2],num[3],num[4]};
char[] array2 = {num[4],num[3],num[2],num[1],num[0]};
int magic = 0;

for (int index = 0 ; index < num.Length ; index++)
{
    if(array1[index] == array2[index])
    {
        magic++;
    }
}

if (magic==num.Length)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
