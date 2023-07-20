// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double[] GenerateRandomArrayDouble(int arraySize, double min, double max) // min, max - диапазон чисел
{
    double[] array = new double[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = Math.Round((new Random().NextDouble() * (max - min) + min), 2);
    }
    return array;
}

double[] mas = GenerateRandomArrayDouble(10, 1, 10);
Console.WriteLine($"[{String.Join(", ", mas)}]");
double maxValue = FindMax(mas);
double minValue = FindMin(mas);
Console.Write($"Разница между максимальным ({maxValue}) и минимальным ({minValue}) ");
Console.WriteLine($"элементом массива равна {Math.Round(maxValue - minValue, 2)}");