/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/

double GetDiff(double[] array)
{
    double minElem = array[0];
    double maxElem = array[0];
    double diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElem)
        {
            minElem = array[i];
        }

        if (array[i] > maxElem)
        {
            maxElem = array[i];
        }
    }

    diff = Math.Round(maxElem - minElem, 2);
    return diff;
}

double[] array = new double[] {2.5, 3.2, 9.93, -4.7};
double difference = GetDiff(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
