// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.

// // 0,5 7 -2 -0,2

// // 1 -3,3 8 -9,9

// // 8 7,8 -7,1 9

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
        matr [i,j] = new Random().Next(-100,100);
        }
        
    }
}
try
{
System.Console.Write("Enter numder of rows n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter numder of columns m = ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,m];
// PrintArray (matrix);
// Console.WriteLine("________");
FillArray (matrix);
Console.WriteLine("There is an array: ");
PrintArray (matrix);
System.Console.Write("Enter the index of the row ");
int a = Convert.ToInt32(Console.ReadLine()) -1;
System.Console.Write("Enter the index of the column ");
int b = Convert.ToInt32(Console.ReadLine()) -1;
int temp = matrix [a,b];
Console.WriteLine($"Your element is {temp} ");
}
catch
{
   Console.Write("You've choosed not acceptable index"); 
}


// Console.Write("{0,6:F1}"