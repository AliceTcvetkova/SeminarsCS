// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int dev1 = number % (7*23);
if (dev1 == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine("не кратно");