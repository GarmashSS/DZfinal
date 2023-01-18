// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем


int [] mass (int size)
{
int [] array = new int [8];

for( int i = 0; i < array.Length; i++ )
{
  Console.Write ($"Введите элемент массива под номером {i}= ");
  array [i] = Convert.ToInt32(Console.ReadLine());

}
return array;
}

int [] arr = mass(8);
Console.WriteLine ($" Массив: {string.Join (", ", arr)}");
