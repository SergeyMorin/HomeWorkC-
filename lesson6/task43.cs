// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[,] arrayuserinput = new double[2, 4];
while (true)
{
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
    if (arrayuserinput[0, 1] == arrayuserinput[1, 1])
        Console.WriteLine("Некорректный ввод, k1=k2 прямые параллельны. Повторите попытку");
    else
        break;
}

XY(arrayuserinput);

double[] XY(double[,] array)
{
    {
        array[0, 2] = (array[0, 3] - array[1, 3]) / (array[1, 1] - array[0, 1]);
        array[1, 2] = array[0, 2];
        array[0, 0] = array[0, 1] * array[0, 2] + array[0, 3];
        array[1, 0] = array[1, 1] * array[0, 2] + array[1, 3];
        double[] point = new double[2] { array[0, 2], array[0, 0] };
        for (int x = 0; x < point.Length; x++)
        {
            Console.Write($"{point[x]} ");
        }
        return point;
    }
}