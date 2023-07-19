// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumElementsInOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] GenerateRandomArray(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to);
    }
    return array;
}

int[] mas = GenerateRandomArray(10, 1, 10);
Console.WriteLine($"[{String.Join(", ", mas)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна: {SumElementsInOddPositions(mas)}");
