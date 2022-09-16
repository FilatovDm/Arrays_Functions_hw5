/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] FillRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GetQuantityEvenNumbers(int[] array)
{
    var quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}

Console.Write("Укажите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];

int[] randomArray = FillRandomArray(array);
int quantityEvenNumbers = GetQuantityEvenNumbers(randomArray);

Console.Write("В массиве ");
Console.Write("[{0}]", string.Join(", ", array));
Console.Write($" количество четных чисел: {quantityEvenNumbers}");
