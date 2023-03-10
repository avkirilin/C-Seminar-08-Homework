// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int MaxSumStringinArray (int[,] array, int maxValue)                                //метод нахождения сумм элементов в каждой строке массива
{                                                                                   //и вывода наименьшего значения сумм в строке
    int minSum = maxValue * array.GetLength(0);
    int numberResString = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumStr = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumStr += array[i,j];
        }
        Console.WriteLine($"сумма строки {i+1} = {sumStr}");
        if (sumStr < minSum)
        {
            minSum = sumStr;
            numberResString = i;
        }
    }
    Console.WriteLine($"Минимальное значение суммы находится в {numberResString + 1} строке массива ");
    return numberResString + 1;
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

Console.Clear();
Console.WriteLine("Введите кол-во строк и кол-во столбцов массива через пробел");
string[] f = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rowsArray = int.Parse(f[0]);
int columnsArray = int.Parse(f[1]);
Console.WriteLine("Введите минимальное и максимальное значения элементов массива в диапазоне 0-9999, через пробел");
string[] d = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int minNum = int.Parse(d[0]);
int maxNum = int.Parse(d[1]);
int[,] myArray = GetArray(rowsArray, columnsArray, minNum, maxNum);
PrintArray(myArray);
int stringMinNumber = MaxSumStringinArray(myArray, maxNum);

