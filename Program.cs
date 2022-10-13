// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// m = 3, n = 4.
// 1 7 -2 -85
// 1 -3 8 -9
// 8 7 -7 9

Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

-----------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2


Console.WriteLine("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [10,10];

FillArrayRandomNumbers(numbers);

if (a > numbers.GetLength(0) || b > numbers.GetLength(1))
{
    Console.WriteLine("Данного элемента нет.");
}

else
{
    Console.WriteLine($"Значение элемента {a} строки и {b} столбца равно {numbers[a-1,b-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(-100, 100)/10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j] + " ");
            }
        Console.Write("]");
        Console.WriteLine("");
    }
}

-----------------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
            
int[,] numbers = new int[a, b];

FillArrayRandomNumbers(numbers);
            
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }

        avarage = avarage / a;
        Console.Write(avarage + "; ");
}

    Console.WriteLine();
    PrintArray(numbers);

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }
    
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }

        Console.Write("]");
        Console.WriteLine("");
        }
}

