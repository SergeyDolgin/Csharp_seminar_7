// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10


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
            matr [i,j] = new Random().Next(1,100);
        }
        
    }
}

void SortArray (int [,] matr)
{
    Console.WriteLine("Matrix after sorting is: ");
    for (int k=0; k<=(matr.GetLength(0)*matr.GetLength(1)); k++)
        {
        int temp = 0;
        for (int i=0; i<matr.GetLength(0); i++)
            {
                for (int j=0; j<(matr.GetLength(1))-1; j++)
                {
                    if (matr [i,j] > matr [i,j+1]) 
                        {
                            temp = matr [i,j];
                            matr [i,j] = matr [i,j+1];
                            matr [i,j+1] = temp;
                       }
                }
           }
                for (int x=0; x<(matr.GetLength(1))-1; x++)
                {
                    for (int z=0; z<matr.GetLength(0); z++)
                    {
                    if (matr [x,z] > matr [x+1,z]) 
                    {
                    temp = matr [x,z];
                    matr [x,z] = matr [x+1,z];
                    matr [x+1,z] = temp;
                    }
                    }
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
FillArray (matrix);
PrintArray (matrix);
SortArray (matrix);
PrintArray (matrix);
}
catch
{
     Console.WriteLine("You have entered something wrong"); 
}