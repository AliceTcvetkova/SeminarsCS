// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

void InputArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,10);
}

void ReleaseArray(float[] array)
{
    float max = 0; float min = 11;
    for (int i = 1; i < array.Length;i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine($"{max - min}");
}


Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
float[] array = new float[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);