/* Задача No14. Общее обсуждение
Напишите программу, которая принимает на вход число и 
проверяет, кратно ли оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да



Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine());


if (number % 7 == 0 & number % 23 == 0 ) 
{
Console.Write(number);
Console.Write("да");
}
else
{
Console.Write(number);
Console.Write("нет");
}

Задача No16. Работа в группах
Напишите программу, которая принимает на вход два числа и 
проверяет, является ли одно число квадратом другого.
● 5, 25 -> да 
● -4, 16 -> да 
● 25, 5 -> да 
● 8,9 -> нет
*/

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());


if (number1 == number2 * number2 | number2 == number1 * number1 ) 
{
Console.Write($"{number1}, {number1} -> да является");
}
else
{
Console.Write($"{number1}, {number1} -> нет, не является");
}
