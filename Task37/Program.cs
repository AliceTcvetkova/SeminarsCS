// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// Средний сам на себя

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1,11);
}

void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
}


Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine();


