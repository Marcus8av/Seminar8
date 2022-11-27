/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

System.Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int minSum = 0;

int[,] CreateArray(int line, int column, int Min, int Max)
{
    int[,] array = new int[line, column];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(Min, Max + 1);
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
            Console.Write(j < array.GetLength(1) - 1 ? $"{array[i, j],4}," : $"{array[i, j],4}");
        }
        System.Console.WriteLine();
    }
}

int SummNumber(int[,] array, int i)
{
    int summ = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        summ += array[i, j];
    }
    return summ;
}

int[,] array2 = CreateArray(m, n, 0, 10);
PrintArray(array2);

int sum = SummNumber(array2, 0);
for (int i = 1; i < array2.GetLength(0); i++)
{
    int temp = SummNumber(array2, i);
    if (sum > temp)
    {
        sum = temp;
        minSum = i;
    }
}

System.Console.WriteLine($"{minSum +1} - строкa с наименьшей суммой ({sum}) элементов ");