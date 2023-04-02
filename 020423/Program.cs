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

