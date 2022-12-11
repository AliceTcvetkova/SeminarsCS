// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное числo: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    if (number / 10000 == number % 10 && (number % 10000) / 1000 == (number % 100) / 10)
        Console.WriteLine("это палиндром");
    else
        Console.WriteLine("не палиндром");
}
else
    Console.WriteLine("это не пятизначное число");