// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] arrayuserinput = new double[2, 4];
Console.WriteLine("Введите коэфиценты k1 ,b1 ,k2 ,b2: ");
for (int i = 0; i < arrayuserinput.GetLength(0); i++)
{
    for (int j = 0; j < arrayuserinput.GetLength(1); j++)
    {
        if (j % 2 == 0)
        {
            continue;
        }
        else
            arrayuserinput[i, j] = double.Parse(Console.ReadLine()!);
    }
}

for (int x = 0; x < XY(arrayuserinput).Length; x++)
{
    Console.WriteLine(XY(arrayuserinput)[x]);
}

double[] XY(double[,] array)
{
    array[0, 2] = (array[0, 3] - array[1, 3]) / (array[1, 1] - array[0, 1]);
    array[1, 2] = array[0, 2];
    array[0, 0] = array[0, 1] * array[0, 2] + array[0, 3];
    array[1, 0] = array[1, 1] * array[0, 2] + array[1, 3];
    double[] point = { array[0, 2], array[0, 0] };
    return point;
}
