// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки A");

double anumber1 = double.Parse(Console.ReadLine()!);
double anumber2 = double.Parse(Console.ReadLine()!);
double anumber3 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B");

double bnumber1 = double.Parse(Console.ReadLine()!);
double bnumber2 = double.Parse(Console.ReadLine()!);
double bnumber3 = double.Parse(Console.ReadLine()!);

double ab = Math.Sqrt(Math.Pow(bnumber1-anumber1, 2) + Math.Pow(bnumber2-anumber2, 2) + Math.Pow(bnumber3-anumber3, 2));
Console.WriteLine(ab);