// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int dev = number / 10;
    int n2 = dev % 10;
    Console.WriteLine(n2);
}
else
    Console.WriteLine("не трёхзначное число");
