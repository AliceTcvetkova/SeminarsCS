// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 7)
    Console.WriteLine("В неделе всего 7 дней");
if (n > 0 && n < 6)
    Console.WriteLine("Рабочий день");
else
    Console.WriteLine("Выходной");