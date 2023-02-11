/* 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

int number;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

if (number == 0)
{
    Console.Write("Вы ввели ноль");
}
else if (number % 2 == 0)
{
    Console.Write($"{number} - чётное");
}
else
{
    Console.Write($"{number} - не чётное");
}