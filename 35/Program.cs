// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите 
// количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] GetRandomarray (int size, int leftRange, int rightRange )
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
    }
int [] mass= GetRandomarray(123, 0, 151);
Console.WriteLine ($"Массив: {string.Join (", ", mass)}");
int count = 0;
for( int i =0; i < mass.Length; i++)
{
    if( mass[i]>= 10 && mass[i] < 100 )
    {
        count = count + 1;
    }
}

Console.WriteLine($"Количество элкментов в заданном отрезке равно: {count} ");
