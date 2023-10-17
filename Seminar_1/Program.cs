// Однострочный коммент
/*
    это
    многострочный 
    коммент
*/

// Задача 1:

// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49


// тип_данных имя_переменных = значение;
// Convert.ToInt32("12") => 12

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = number * number;

// Console.WriteLine("Квадрат от числа " + number + " = " + result);

// Задача 2:
//Напишите программу, которая
// будет выдавать название дня недели
// по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// camelCase: переменная -1 большое слово
// 1 буква маленькая, следующее слово начинается с большой
// Console.Write("Введите номер дня недели: ");
// int numberOfDay = Convert.ToInt32(Console.ReadLine());
// // "==" - проверка на равенство (5 == 5 => true)
// if(numberOfDay == 1) //Точку с запятой перед "{" НЕ ставлю
// {
//     Console.WriteLine("Понедельник");
// }
// else if (numberOfDay == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (numberOfDay == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (numberOfDay == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (numberOfDay == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (numberOfDay == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (numberOfDay == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня не существуент");
// }

//Форматироавния текста в VSC:Visual Studio Code on Windows - Shift + Alt + F
//Visual Studio Code on MacOS - Shift + Option + F
//Visual Studio Code on Ubuntu - Ctrl + Shift + I

// Задача 3:

// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

using System.Runtime.ConstrainedExecution;

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    N *= -1;
    Console.WriteLine("Вы ввели отрицательное чилсо N, я умножу его на -1");
}
int negativeN = -N; // -N (N *-1)

while(negativeN <= N)
{
    Console.Write(negativeN + "  ");
    negativeN += 1;
}