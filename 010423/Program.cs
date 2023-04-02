/* 
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

Console.Write("Введи любое число: ");
int a = int.Parse(Console.ReadLine());

if (a > 99 ) {
    
    Console.Write($"{a} -> ");
    Console.Write(a > 99 ? a.ToString()[2] : '-');
}
else {

    Console.Write($"{a} -> ");
    Console.Write("Третьей цифры нет");
}



Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y).



Console.Write("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine());

string result = GetNumberOfQuarter(a);
Console.Write(result);
string GetNumberOfQuarter(int a)
{

    if (a == 1)
    {
        return "x > 0 & y > 0";
    }
    if (a == 2)
    {
        return "x < 0 & y > 0";
    }
    if (a == 3)
    {
        return "x < 0 & y < 0";
    }
    if (a == 4)
    {
        return "x > 0 & y < 0";
    }
    return "0";
}
Console.WriteLine("Введите ax");
double ax = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ay");
double ay = double.Parse(Console.ReadLine());
Console.WriteLine("Введите bx");
double bx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите by");
double by = double.Parse(Console.ReadLine());

double distance = GetDistance(ax, ay, bx, by);

Console.WriteLine($"расстояние между точками {distance}");

double GetDistance (double ax, double ay, double bx, double by)
{
    return Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2));
}

 Задача No21. Работа в группах
Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние 
между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21

AB = {Bx - Ax; By - Ay};
AB = √((xb - xa)2 + (yb - ya)2)


Console.Write("Введите x: ");
int xa = int.Parse(Console.ReadLine());

Console.Write("Введите y: ");
int ya = int.Parse(Console.ReadLine());

Console.Write("Введите x: ");
int xb = int.Parse(Console.ReadLine());

Console.Write("Введите y: ");
int yb = int.Parse(Console.ReadLine());

double result = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
 
Console.Write(result);

int x = int.Parse(Console.ReadLine());
for(int i =1;i<=x;i++)
{
    if(i ==x)
    {
        int r = i*i;
        Console.Write(r);
        break;
    }
    int rez = i*i;
    Console.Write(rez + ", ");
}


*/

/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4


Console.WriteLine("Введите любое число ");
double N = double.Parse(Console.ReadLine());

double result = GetNumber(N);

if (N < 1)
{
    Console.WriteLine($"Неверное значение. Повторите ввод");
}

while (N > 1)
{
    Console.WriteLine($"таблица квадратов чисел от 1 до {N}");

    double GetNumber(double N)
    {
        return (N * N);

    }
}


Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Console.Write(a > 99 ? a.ToString()[2] : '-');
*/

/* Console.WriteLine("Введите любое выражение ");
string a = Console.ReadLine();
string result = IsPalindrom();

static bool IsPalindrom(string word, bool ignoreCase = true)
{
    if (ignoreCase)
    {
        word = word.ToLowerInvariant();
    }

    for (int first = 0, last = word.Length - 1; first < last; ++first, --last)
    {
        if (word[first] != word[last])
        {
            return false;
        }
    }

    return true;
} */

/* if (a > 99999 | a < 10000)
{
    Console.Write("Данные введены не верно ");
    break;
} 

for (int first = 0, last = a.Length - 1; first < last; ++first, --last)
{
    if (a[first] != a[last])
    {
     return false;
    }
}

public static bool Palindrom(string s)
{
    for (int i = 0; i < s.Length / 2; i++)
 
        if (s[i] != s[s.Length - i - 1])
            return false;
    return true;
}


/* Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да



using System;

class Palindr
{
    public static bool Palindromtest(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)

            if (s[i] != s[s.Length - i - 1])
                return false;
        return true;
    }

    static void Main()
    {
        string s;
        Console.WriteLine("Анализ палиндромов. Введите строку:");
        s = Console.ReadLine();
        if (Palindromtest(s))
            Console.WriteLine("Эта строка - палиндром");
        else Console.WriteLine("Эта строка - не палиндром");
        Console.ReadLine();
    }
}


using System;

class Is_in;
{

    int is_in(char* s, char с)
    {
        while (*s)
            if (*s == c) return 1;
            else s++;
        return 0;
    }
}
*/