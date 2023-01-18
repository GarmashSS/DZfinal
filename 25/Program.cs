// Задача 25: Напишите цикл, который принимает на вход два
//  числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine ("Введите первое число");
 int a = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine ("Введите второе число");
 int b = Convert.ToInt32(Console.ReadLine());
 //int count = 1;
 int result = 1;

 for( int i = 1; i<= b; i++)
 {
    result *=a;
    
 }

//  int degree(int b)
//   {

//  }
//  for (int i = 1; i<=b; i++)

Console.WriteLine($"Результат: {result}"); 
