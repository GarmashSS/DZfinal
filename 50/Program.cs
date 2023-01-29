// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет
// 

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine());
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] matrix = new int[n, m];
Console.WriteLine("Массив: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
{
    matrix[i, j] = random.Next(10, 99);
Console.Write("{0} ", matrix[i, j]);
}
Console.WriteLine();
}
    if (pos1 < 0 | pos1 > matrix.GetLength(0) - 1 | pos2 < 0 | pos2 > matrix.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[pos1, pos2]);
}
Console.ReadLine();