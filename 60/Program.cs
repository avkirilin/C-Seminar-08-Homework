// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.WriteLine("Введите размерность трехмерного кубического массива от 2 до 4");
int sizeArray = Convert.ToInt32(Console.ReadLine());
if (sizeArray >=2 && sizeArray <=4)
{
int[] numbers = new int[sizeArray * sizeArray * sizeArray];
int count = 0;
while (numbers.Distinct().ToArray().Length < numbers.Length)
{
    int temp = new Random().Next(10, 100);
    if (!numbers.Contains(temp))
    {
        numbers[count] = temp;
        count++;
    }
}

int temp2 = new Random().Next(10, 100);
while (numbers.Contains(temp2))
{
    temp2 = new Random().Next(10, 100);
}
numbers[^1] = temp2;
Console.WriteLine (numbers);

int[,,] arr = new int[sizeArray, sizeArray, sizeArray];
int position = 0;
for (int i = 0; i < sizeArray; i++)
{
    for (int j = 0; j < sizeArray; j++)
    {
        for (int k = 0; k < sizeArray; k++)
        {
            arr[i, j, k] = numbers[position];
            Console.Write($"{arr[i, j, k]} index = ({i},{j},{k})  ");
            position++;
        }
        Console.WriteLine();
    }
}
}
else Console.WriteLine("Ошибка!!! Введите корректное значение линейногго параметра массива (от 2 до 4)");