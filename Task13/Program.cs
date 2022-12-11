// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int third = 1;
if (number > 99)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    third = number % 10;
        Console.WriteLine($"третья цифра: {third}");
}
else
    Console.WriteLine("нет третьей цифры");