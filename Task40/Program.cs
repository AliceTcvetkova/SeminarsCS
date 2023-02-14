// Проверка сторон треугольника

Console.Write("Введите стороны треугольника: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());

if ((n1 + n2 > n3) && (n3 + n2 > n1) && (n1 + n3 > n2))
    Console.Write("Может");
else
    Console.Write("Не может");
