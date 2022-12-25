// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

double AvrgElementsColumns(int[,] matrix, int line, int columns)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double average = 0;
    for (int j = 0; j < columns; j++)
    {
        double summ = 0;
        for (int i = 0; i < line; i++)
        {
            summ = summ + matrix[i, j];

        }
        average = summ / line;

        Console.Write($"{average}; ");
    }
    return average;
}



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] TwoDimArray(int line, int columns, int left, int right)
{
    int[,] array = new int[line, columns];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(left, right);
        }
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
int[,] matrix = TwoDimArray(line, columns, 0, 10);  //Two-dimensional
PrintArray(matrix);
double avrg = AvrgElementsColumns(matrix, line, columns);
