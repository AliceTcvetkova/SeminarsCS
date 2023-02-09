// Суперсдвиг
// Дана последоваетльность из N целых чисел и число K. Необходимо сдвинуть всю последовательность 
// (сдвиг циклический) на K элементов вправо, если K - положительное и влево, если отрицательное.
Console.Clear();
Console.WriteLine("Введите количество целых чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целые числа: ");
int[] numbers = Console.ReadLine().
Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Введите число сдвига: ");
int k = Convert.ToInt32(Console.ReadLine());
k %= n; // убирает все лишние прохождения
int[] result = new int[n];
if (k > 0)
{
    for (int i = 0; i < k; i++)
        result[i] = numbers[n - k + i];
    for (int i = 0; i < n - k; i++)
        result[k + i] = numbers[i];
}
else
{
   k = (-1) * k;
    for (int i = 0; i < k; i++)
        result[n - k + i] = numbers[i];
    for (int i = 0; i < n - k; i++)
        result[i] = numbers[k + i]; 
}
Console.WriteLine(string.Join(" ", result));












//foreach (int element in size) 
//    Console.WriteLine(element * 2);
