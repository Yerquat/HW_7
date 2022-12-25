// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] TwoDimArray(int line, int columns, int left, int right)
{
    double[,] array = new double[line, columns];
    Random random = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int n = new Random().Next(0, 2);
            int k = new Random().Next(left, right);
            array[i, j] = Math.Pow(-1, n) * random.NextDouble() * k; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
            Console.Write(" {0,6:F2} ", array[i, j]); // {0,6:F1} число после F (1) показываает сколько знаков после запятой поставить.
        }
        Console.WriteLine();
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int line = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
double[,] matrix = TwoDimArray(line, columns, -100, 100);  //Two-dimensional




