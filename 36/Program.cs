// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] GetRandomarray (int size, int leftRange, int rightRange )
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
}

int [] mass= GetRandomarray(8, -9, 9);
Console.WriteLine ($"Массив: {string.Join (", ", mass)}");
int[] sum = mass;
int summ = 0;
for( int i = 1; i < sum.Length; i++)
{
    if (i % 2 == 1)
    summ = summ + sum[i];
}
Console.WriteLine($"Сумма нечетных элементов {summ}");

