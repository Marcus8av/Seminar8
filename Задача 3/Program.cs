/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

System.Console.WriteLine("Введите количество строки первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов первой матрицы и строк второй матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов второй матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int line, int column, int Min, int Max)
{
    int[,] matrix = new int[line, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(Min, Max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j],4}," : $"{matrix[i, j],4}");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix1 = CreateMatrix(m, n, 0, 10);
System.Console.WriteLine("Матрица №1:");
PrintMatrix(matrix1);
System.Console.WriteLine();

int[,] matrix2 = CreateMatrix(n, l, 0, 10);
System.Console.WriteLine("Матрицы №2:");
PrintMatrix(matrix2);

int[,] resultMatrix = new int[m, l];

void Proisvmatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
System.Console.WriteLine();

Proisvmatrix(matrix1, matrix2, resultMatrix);
System.Console.WriteLine("Произведение матриц равняется:");
PrintMatrix(resultMatrix);