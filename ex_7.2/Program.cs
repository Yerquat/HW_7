// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double ElementArray(double[,] matrix,int line, int columns, int numberline, int numbercolumns)
{
    
    int p = numberline;
    int q = numbercolumns;
    if(p >= line || q >= columns) 
    {
    Console.WriteLine("Такого элемента нет");
    Console.WriteLine();
    
    }
    else
    {
    Console.WriteLine($"Элемент на строке {p} и столбце {q}: " + " {0,6:F2} ", matrix[p, q]); 
    }                                       //Console.WriteLine(matrix[p, q]);
    return matrix[p, q];
   
}

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
int numberline = EnterData("Введите номер строки: ");
int numbercolumns = EnterData("Введите номер столбца: ");
double[,] matrix = TwoDimArray(line, columns, -100, 100);  //Two-dimensional
double element =  ElementArray(matrix, line, columns, numberline, numbercolumns);

// вводим количество строк
// вводим  столбцок 
// выводим массив
// вводим номер строки
// вводим номер столбца
// выводим элемент
