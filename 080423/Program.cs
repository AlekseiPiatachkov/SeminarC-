// Написать программу которая находит сумму 4 чисел. 
//Числа вводятся пользователем из консоли.
//Если пользователь ввел не число необходимо вывести 
//пользователю сообщение "Введены некорректные данные".
/*
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Введите четвёртое число ");
int d = int.Parse(Console.ReadLine());

int result = 0;

int[] n = new int[] { a, b, c, d };

GetSumNumber(n);

int GetSumNumber(int a, int b, int c, int d)
{
    for (int i = 0; i < n; i++)
    {
        result = result + n[i];
    }
    return result;
}*/
/*
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] array = GenerateArray(9);
PrintArray(array);
GetNumber(array);

PrintArray(array);

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

void GetNumber(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}
*/
/*Задача 33: Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да*/

/*int[] array = GenerateArray(9);
PrintArray(array);
GetFindNumber(array);

PrintArray(array);

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

void GetFindNumber(int[] arr)
{
    int a = 4;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == a)
        Console.WriteLine($"{arr[i]}");

        
    }
}
Console.WriteLine($"{} -> нет ");
void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}

/*
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]

Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да

Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении
 сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21



Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 

int[] array = GenerateArray(10);
PrintArray(array);

GetProdactParNumber(array);
PrintArray(array);

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}

int[] GetProdactParNumber(int[] arr)
{
    int[] result = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        result[i] = arr[i] * arr[arr.Length-1-i];
    }
    return result;
} */
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

//int[] array = new int[4];
int[] array = GenerateArray(10);
CreationArray(arr);
PrintArray(arr);

int[] CreationArray(int length);
{
     int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random().Next(100,999);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}






