// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void PrintArray<T>(T[,] arr)
{
    Console.WriteLine("Заполненный массив по спирали: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}" + new string(' ', 6 - arr[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}
string[,] sqareArray = new string[4, 4];
int temp = 1; int i = 0; int j = 0;
while (temp <= sqareArray.GetLength(0) * sqareArray.GetLength(1))
{
    sqareArray[i, j] = temp.ToString().Length < 2 ? $"0{temp.ToString()}" : temp.ToString();
    temp++;
    if (i <= j + 1 && i + j < sqareArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareArray.GetLength(1) - 1)
        j--;
    else
        i--;
}
PrintArray(sqareArray);