/* 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

double number1, number2, number3;
Console.Write($"Введите 1 число: ");
double.TryParse(Console.ReadLine()!, out number1);
Console.Write($"Введите 2 число: ");
double.TryParse(Console.ReadLine()!, out number2);
Console.Write($"Введите 3 число: ");
double.TryParse(Console.ReadLine()!, out number3);

double max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write($"максимальное число равно {max}");