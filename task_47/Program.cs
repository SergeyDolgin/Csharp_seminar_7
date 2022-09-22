// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void PrintArray (double [,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", matr[i, j]);
        }
    Console.WriteLine();
    }
}
void FillArray (double [,] matr)
{
    Random x = new Random();
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
        matr[i, j] = Convert.ToDouble(x.Next(-1000, 1000)/10.0);
        }
        
    }
}
try
{
System.Console.Write("Enter numder of rows n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter numder of columns m = ");
int m = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [n,m];
// PrintArray (matrix);
// Console.WriteLine("________");
FillArray (matrix);
PrintArray (matrix);
}
catch
{
     Console.WriteLine("You should have entered integer number"); 
}