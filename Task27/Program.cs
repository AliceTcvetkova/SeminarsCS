// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int res = 0; 
while (a > 0)
{
    res += a % 10;
    a /= 10;
}
Console.WriteLine(res);
