/* На вход будет подаваться число (сумма вклада). 
При значении меньше 100, будет начислено 5 %, если 
значение находится в диапазоне от ста до двухсот — 7 %, 
если больше — 10 %. Отработав, программа должна вывести 
общую сумму с начисленными процентами. Для решения этой 
задачи воспользуемся выражением 
Convert.ToDouble(Console.ReadLine()), которое нам 
пригодится для 
получения вводимого с клавиатуры числа.


Console.WriteLine("Введите сумму вклада: ");
double n = Convert.ToDouble(Console.ReadLine());

ProcentToVklad(n);

static void ProcentToVklad(double number)
{

    if (number < 100)
    {
        Console.WriteLine($" Сумма {number} + 5% = {number + (number * 5 / 100)}");
    }
    if (number > 100 && number < 200)
    {
        Console.WriteLine($" Сумма {number} + 7% = {number + (number * 7 / 100)}");
    }
    if (number > 200)
    {
        Console.WriteLine($" Сумма {number} + 10% = {number + (number * 10 / 100)}");
    }
}

Начав тренировки, лыжник в первый день пробежал 10 км. 
Каждый следующий день он увеличивал пробeг на 10% от пробега предыдущего дня. 
Определить в какой день суммарный пробег за все дни превысит 100 км.

double distance = 10;
double sum = 0;
double procent = distance * 10 / 100;
int day = 1;

GetDistance(day);
Console.WriteLine(day);

double GetDistance(double arr)
{
    while (sum <= 100)
    {
        distance = distance + procent;
        sum = distance + sum;
        procent = distance * 10 / 100;
        day++;
    }
    return day;
}

Блок 1. Выводит все элементы массива.
*/

//int[] array = { 23, 34, 45, 24, 36, 54, 75 };
//PrintArray(array);
//ReversArray(array);
/*void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}
*/
// Блок 2. Выводит все элементы массива в обратном порядке.

/*void ReversArray(int[] arr)
{
    int length = arr.Length;
    for (int i = length - 1; i >= 0; i--)
    {
        Console.Write($" {arr[i]} ");
    }
}*/

//Блок 3. Выводит чётные элементы массива.

/* GetEvenNumberArray(array);

void GetEvenNumberArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if(arr[i] % 2 == 0)
        Console.Write($"{arr[i]} ");
    }
} */

//Блок 4. Выводит все элементы массива через 1.


/* GetNumberViaNumberArray(array);
void GetNumberViaNumberArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i += 2)
    {
        Console.Write($"{arr[i]} ");
    }
}
*/
//Блок 5. Выводит все элементы массива пока не встретится элемент -1.

/*
GetNumberWishOutOneArray(array);
void GetNumberWishOutOneArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (arr[i] != -1)
            Console.Write($"{arr[i]} ");
        else 
            break;
    }
} */

//Блок 1. В массив добавляется элемент в конец.

/* GetNumberPlusArrayToEnd(array);
void GetNumberPlusArrayToEnd(int[] arr)
{
    int length = arr.Length;
    int add = 21;
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1)
            Console.Write($"{arr[i]} ");
        else
            Console.Write($"{arr[i]} {add} ");
    }
} */

//Блок 2. В массив добавляется элемент в начало.

/* GetNumberPlusArrayToStart(array);
void GetNumberPlusArrayToStart(int[] arr)
{
    int length = arr.Length;
    int add = 21;
    for (int i = 0; i < length; i++)
    {
        if (i == 0)
            Console.Write($"{add} {arr[i]} ");
        else
            Console.Write($"{arr[i]} ");
    }
} */

//Блок 3. В массив добавляется элемент в позицию (допустим 4).
/*
GetNumberPlusArrayPosition(array);
void GetNumberPlusArrayPosition(int[] arr)
{
    int length = arr.Length;
    int add = 21;
    for (int i = 0; i < length; i++)
    {
        if (i == 3)
            Console.Write($"{add} {arr[i]} ");
        else
            Console.Write($"{arr[i]} ");
    }
} */

//Блок 4. Из массива удаляется элемент с конца.

/* GetNumberMinusArrayToEnd(array);
void GetNumberMinusArrayToEnd(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1)
            Console.Write($"{arr[i]} ");
        else
            break;
    }
}*/

//Блок 5. Из массива удаляется элемент с начала.

/* GetNumberMinusArrayFirstPosition(array);
void GetNumberMinusArrayFirstPosition(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (i == 0)
            Console.Write("");
        else
            Console.Write($"{arr[i]} ");
    }
} */

//Блок 6. Из массива удаляется элемент с позиции (допустим 5)

//int[] array = { 23, 34, 45, 24, 36, 1, 54, -1, 75 };
/* GetNumberMinusArrayPosition(array);
void GetNumberMinusArrayPosition(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (i == 4)
            Console.Write("");
        else
            Console.Write($"{arr[i]} ");
    }
} */

//Блок 7. Создание массива из двух массивов. В итоговом массиве должны быть элементы первого и второго массива.
/*
int[] array1 = { 23, 34, 5, 4, 36, 1, 54, -1, 5 };
int[] array2 = { 3, 56, 45, 24, 6, 12, 58, -1, 75, -23 };

int[][] toMerge = { array1, array2 };
int[] result = new int[array1.Length + array2.Length];

//GetNumberMinusArrayPosition(toMerge);

//void GetNumberMinusArrayPosition(int[][] toMerge)

    for (int i = 0, j = 0; i < toMerge.Length; i++)
{
    for(int k = 0; k < toMerge[i].Length; k++)
    {
        result[j] = toMerge[i][k];
        j++;
    }
} */
/*
int[] array1 = { 1, 2, 3 };
int[] array2 = { 4, 5, 6 };
int[][] toMerge = { array1, array2 };

int[] result = new int[array1.Length + array2.Length];

for (int i = 0, j = 0; i < toMerge.Length; i++)
{
    for(int k = 0; k < toMerge[i].Length; k++)
    {
        result[j] = toMerge[i][k];
        j++;
    }
} */

int[] number = new int[5];
number[0] = 2;
number[1] = 3;
number[2] = 5;
number[3] = 8;
number[4] = 111;

/* int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    sum = number[i] + sum;
}
Console.Write(sum);*/

int max = number[0];

for (int i = 0; i < number.Length; i++)
{
    if (number[i] > max) max = number[i];
}
Console.Write(max);