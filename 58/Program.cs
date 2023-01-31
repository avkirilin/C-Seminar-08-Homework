// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int rows, int columns, int minValue, int maxValue)                  //метод получения двумерного массива с рандомными значениями
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)                                                      //метод вывода двумерного массива с корректными отступами
{
    Console.WriteLine();
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] >= 0 && inArray[i, j] < 10) Console.Write($"     {inArray[i, j]}");
            if (inArray[i, j] >= 10 && inArray[i, j] < 100) Console.Write($"    {inArray[i, j]}");
            if (inArray[i, j] >= 100 && inArray[i, j] < 1000) Console.Write($"   {inArray[i, j]}");
            if (inArray[i, j] >= 1000 && inArray[i, j] < 10000) Console.Write($"  {inArray[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] MatrixMultiplication(int[,] array1, int[,] array2)                               //метод перемножения матриц
{
    int[,] resultMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Ошибка!!! Нет возможности перемножить матрицы, число строк первой должно совпадать с числом столбцов второй");
        return resultMatrix;
    }
    else
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    sum += array1[i,k] * array2[k,j];
                }
                resultMatrix[i,j] = sum;
            }
        }
    }
    return resultMatrix;
}

Console.Clear();
Console.WriteLine("Введите кол-во строк и кол-во столбцов первой матрицы через пробел");
string[] rowsColumns1 = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rowsArray1 = int.Parse(rowsColumns1[0]);
int columnsArray1 = int.Parse(rowsColumns1[1]);
Console.WriteLine("Введите минимальное и максимальное значения элементов первой матрицы в диапазоне 0-99, через пробел");
string[] valueMinMaxInArray1 = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int minNum1 = int.Parse(valueMinMaxInArray1[0]);
int maxNum1 = int.Parse(valueMinMaxInArray1[1]);
Console.WriteLine("Введите кол-во строк и кол-во столбцов второй матрицы через пробел");
string[] rowsColumns2 = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rowsArray2 = int.Parse(rowsColumns2[0]);
int columnsArray2 = int.Parse(rowsColumns2[1]);
Console.WriteLine("Введите минимальное и максимальное значения элементов второй матрицы в диапазоне 0-99, через пробел");
string[] valueMinMaxInArray2 = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int minNum2 = int.Parse(valueMinMaxInArray2[0]);
int maxNum2 = int.Parse(valueMinMaxInArray2[1]);
int[,] myArray1 = GetArray(rowsArray1, columnsArray1, minNum1, maxNum1);
PrintArray(myArray1);
int[,] myArray2 = GetArray(rowsArray2, columnsArray2, minNum2, maxNum2);
PrintArray(myArray2);
int[,]multiplicationArray = MatrixMultiplication(myArray1, myArray2);
PrintArray(multiplicationArray);