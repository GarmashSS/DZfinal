// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

//while (num!= stop)

int num;
int count = 0;
string? answer = null;
string stop = "stop";

while(true)
{
    answer = Console.ReadLine();
    if(answer == stop)
    {
        break;
    }
    num = Convert.ToInt32(answer);
    if (num > 0) count++;

}

Console.WriteLine( count);