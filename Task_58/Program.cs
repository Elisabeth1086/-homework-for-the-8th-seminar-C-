// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = ReadInt("Введите количество строк матрицы №1: ");
int n = ReadInt("Введите количество столбцов матрицы №1: ");
int r = ReadInt("Введите количество строк матрицы №2: ");
int t = ReadInt("Введите количество столбцов матрицы №2: ");


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(1, 5);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int[,] NewMatr(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    if (matrix1.GetLength(0) != matrix2.GetLength(1))
    {
        Console.WriteLine("Нельзя перемножить");
    }
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
            }
        }
    }
    return matrix3;
}


var myMatrix = GenerateMatrix(m, n);
System.Console.WriteLine();
System.Console.WriteLine("Массив № 1");
PrintMatrix(myMatrix);
var myMatrix2 = GenerateMatrix(r, t);
System.Console.WriteLine();
System.Console.WriteLine("Массив № 2");
PrintMatrix(myMatrix2);
System.Console.WriteLine();
System.Console.WriteLine("Произведение 2-х матриц");
PrintMatrix(NewMatr(myMatrix, myMatrix2));