// Упорядочивание массива.
/*
int[] arr = { 2, 4, 5, 1, 23, 18, 31 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSoft(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = j + 1; j < array.Length - 1; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }    
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSoft(arr);
PrintArray(arr);
*/

/* Дан текст. В тексте нужно все пробелы заменить вертикальной чёрточной, маленькие буквы "к" 
заменить на большие буквы "К", а большие буквы "С" заменить на маленькие буквы "с".


string text = " - Я думаю, - сказал князь, улыбаясь, что,"
            + " ежели бы вас послали вместо нашего милого Винценгероде"
            + " вы бы взяли приступом согласие прусского короля"
            + " Вы так красноречивы, Вы дадите мне чаю";

// string s = "qwerty"
//             012
// s[3] = r

string Replase(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, 'к', 'К');
Console.WriteLine(text);
Console.WriteLine();
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, ' ', '|');
Console.WriteLine(newText);


int[] a = { 10, 18, 2, 5, 55, 46, 32, 54, 89, 21 };

void SelectionSoft(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = j + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
         int temporary = array[i];
         array[i] = array[maxPosition];
         array[maxPosition] = temporary;
    }
}
*/

// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N. 4 -> 24 5 -> 120

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

/* Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int result = GetNumberToProizv(a);
Console.WriteLine(result);

int GetNumberToProizv(int number)
{
    int result = 1;
    for (var i = 1; i <= number; i++)
    {
        result *= i;  
    }
    return result;
}
*/
/*
 Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
QuestMax(arr);
Console.WriteLine(QuestMax(arr));

void FillArray(int[] sdf)
{
    Random random = new Random();
    for (int i = 0; i < sdf.Length; i++)
    {
        sdf[i] = random.Next(A, B);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int QuestMax(int[] array)
{
    int max = arr[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
*/



/* Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());

Console.Write(Exponention(A, B));

int Exponention(int A, int B)
{
    int i = 1;
    int result = 0;
    while (B > i)
    {
        if (i == 1) result = A * A;
        else result = A * result;
        i++;
    }
    return result;
} */


/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"{number} -> ");
Console.Write(GetSumArray(number));

int GetSumArray(int number)
{
    int i = 0;
    int sum = 0;
    while (number > 10)
    {
        sum = number % 10 + sum;
        number = number / 10;
        i++;
    }
    sum = number + sum;
    return sum;
}
*/

/* int[] arr = new int[A];
FillSumArray(arr);
PrintArray(arr);

Console.WriteLine(QuestMax(arr));

void FillSumArray(int[] number)
{

    for (int i = 0; i < sdf.Length; i++)
    {
        sdf[i] = random.Next(A, B);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
*/

/* Задача 29: Напишите программу, которая задаёт массив из 8 
элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] 

Console.WriteLine("Введите весемь элементов массива: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());
int f = int.Parse(Console.ReadLine());
int g = int.Parse(Console.ReadLine());
int h = int.Parse(Console.ReadLine());

int[] arr = { a, b, c, d, e, f, g, h };
int count = arr.Length;

Console.Write($"{a}, {b}, {c}, {d}, {e}, {f}, {g}, {h} -> ");

PrintArray(arr);

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
            Console.Write($" {col[position]} ");
        position++;
    }
}

/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,8);
        index++;
    }
}

int year = Method3();

Console.WriteLine(year);

int Method3()
{
    return DateTime.Now.Year;
}

Console.WriteLine("Введите необходимое число: ");
int count = int.Parse(Console.ReadLine());

Console.WriteLine("Введите необходимый текс: ");
string text = Console.ReadLine();

string res = Method4(count, text);
Console.WriteLine(res);

string Method4(int count, string text)
{
    int index = 0;
    string result = string.Empty;
    while (index < count)
    {
        result = result + text;
        index++;
    }
    return result;
}

void Method1()
{
    Console.WriteLine("Текст сообщения");
}

Method1(); 

Console.WriteLine("Введите необходимый текс: ");

string msg = Console.ReadLine();
Method2(msg);
Console.WriteLine(msg);

void Method2(string msg)
{
    Console.WriteLine(msg);
} 


Method21(4, "Добро пожаловать");

void Method21(int count, string text)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(text);
        i++;
    }
}


for (int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($" {i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

/* Дан текст. В тексте нужно все пробелы заменить вертикальной чёрточной, маленькие буквы "к" 
заменить на большие буквы "К", а большие буквы "С" заменить на маленькие буквы "с".

*/




string text = " - Я думаю, - сказал князь, улыбаясь, что,"
            + " ежели бы вас послали вместо нашего милого Винценгероде"
            + " вы бы взяли приступом согласие прусского короля"
            + " Вы так красноречивы, Вы дадите мне чаю";


string ChengeText(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = ChengeText(text,' ', '|');
Console.WriteLine(newText);
newText = ChengeText(newText,'к', 'К');
Console.WriteLine(newText);