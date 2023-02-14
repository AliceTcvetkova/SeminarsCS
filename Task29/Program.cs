// Напишите программу, которая спрашивает у пользователя кол-во элементов массива, 
// затем сами элементы. Программ должна вывести массив на экран.
Console.WriteLine("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива: ");
string[] array = Console.ReadLine().Split(", ");
Console.WriteLine($"[{string.Join(", ",array)}]");