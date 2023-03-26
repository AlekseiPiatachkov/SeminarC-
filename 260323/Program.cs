/* Напишите программу, которая выводит случайное трехзначное
 число и удаляет вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98
*/


Random random = new Random();
int randomValue = random.Next(99, 1000);

int firstDigits = randomValue / 100 * 10;

int secomdDigits = randomValue % 10;

Console.WriteLine(randomValue);
Console.WriteLine(firstDigits + secomdDigits);

