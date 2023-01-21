// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GetRandomarray (int size, int leftRange, int rightRange )
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
    }
int [] mass= GetRandomarray(8, 1, 99);
Console.WriteLine ($"Массив: {string.Join (", ", mass)}");
int max = mass[0];
int min = mass[0];
for( int i = 1; i < mass.Length; i++)
{
    if (min > mass[i])
    { 
    min = mass[i];
    }
    if (max < mass[i])
    {
    max = mass[i];
    }
}


Console.WriteLine($"Минимальное значение = {min} ");
Console.WriteLine($"Максимальное значение = {max} ");
Console.WriteLine($"Разница = {max - min} ");