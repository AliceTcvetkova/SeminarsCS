// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
// 78->8
// 12->2
// 85->8
Console.Clear();
Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int dev = n2 % n1;
if (dev == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine(dev);