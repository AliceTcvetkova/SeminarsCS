// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координат x точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат y точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат z точки А: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты x точки В: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат y точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координат z точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2));
