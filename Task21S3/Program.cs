// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D прострастве.
// А(3,6);В(2,1) -> 5,09
// A(7,5);B(1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Введите координат x точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат y точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты x точки В: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат y точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2));