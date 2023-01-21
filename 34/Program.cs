// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] GetRandomarray (int size, int leftRange, int rightRange )
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
    }
int [] mass= GetRandomarray(8, 100, 999);
Console.WriteLine ($"Массив: {string.Join (", ", mass)}");
int count = 0;

for( int i =0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.WriteLine($"Количество четных чисел в массиве : {count}");
