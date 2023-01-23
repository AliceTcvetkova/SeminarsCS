// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = 1;
if (b > 0)
{
    for (int i = 1; i < b + 1; i++)
    res = res * a;
} 
else res = 1;
Console.WriteLine(res);