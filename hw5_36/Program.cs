/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] FillRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

int GetSumOddElem(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+ 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void PrintResult(int[] array, int sum)
{
    Console.Write("В массиве ");
    Console.Write("[{0}]", string.Join(", ", array));
    Console.Write($" сумма элементов, стоящих на нечетных позициях: {sum}");
}

Console.Write("Укажите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];

int[] randomArray = FillRandomArray(array);
int sumOddElem = GetSumOddElem(randomArray);

PrintResult(randomArray, sumOddElem);



