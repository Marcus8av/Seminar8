/*Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

System.Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int line, int column, int Min, int Max)
{
    int[,] array = new int[line, column];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            array[i, j] = rnd.Next(Min, Max  + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(j < array.GetLength(1) -1  ? $"{array[i, j],4}," : $"{array[i,j],4}");
        }
        System.Console.WriteLine();
    }
}

void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
int[,] array2 = CreateArray(m, n, 0, 10);
PrintArray(array2);
System.Console.WriteLine();
System.Console.WriteLine("Упорядоченный массив от большего числа к меньшему:");
NewArray(array2);
PrintArray(array2);