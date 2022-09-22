
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray (int [,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray (int [,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,10);
        }
        
    }
}

void FindAverage (int [,] matr)
{
    Console.Write("The average NUMBER of each column is: ");
    for (int i=0; i<matr.GetLength(1); i++)
    {
        double average = 0;
        double sum = 0;
        for (int j=0; j<matr.GetLength(0); j++)
        {
           sum = sum + matr [j,i];
        }
        average = sum/matr.GetLength(0);
        Console.Write("{0,6:F1}", average);
    }
    Console.Write(". ");
}
try
{
System.Console.Write("Enter numder of rows n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter numder of columns m = ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,m];
FillArray (matrix);
PrintArray (matrix);
FindAverage (matrix);
}
catch
{
     Console.WriteLine("You should have entered integer number"); 
}