// Напишите программу для нахождения максимального числа ягод, 
// которое может собрать за один заход собирающий модуль, 
// находясь перед некоторым кустом заданной во входном файле грядки.

Console.Clear();
Console.WriteLine("Введите количество кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество ягод на грядке: ");
int[] array = new int[n];
string[] input = Console.ReadLine().Split(" ");
for (int i = 0; i < input.Length; i++)
{
    array[i] = int.Parse(input[i]);
}
int maxSum = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > maxSum)
        maxSum = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxSum)
        maxSum = array[0] + array[1] + array[array.Length - 1];
if (array[array.Length - 2] + array[array.Length - 1] + array[0] > maxSum)
        maxSum = array[array.Length - 2] + array[array.Length - 1] + array[0];
Console.WriteLine(maxSum);
//    if (i < n - 1)
//    {
//        for (int j = 1; j < 4; j++)
//      {
//            sum = sum + a;
//        }
//    }
//    if (i = n - 1)
//int sum = 0;
//int max = 0;
//int a = 0;
//    if (sum > max)
//        max = sum;
//}
//Console.WriteLine($"Максимальное количество ягод на грядке: {max}");
//Console.Clear();
//int maxSubArray(int [arr]){
//    int localsum = 0;
//    int globalsum = int.MinValue;
//    for (int i = 1; i < arr.Length; i++){
//        localsum = Math.Max(arr[i], arr[i] + localsum);
//        globalsum = Math.Max(globalsum, localsum);
//    }
//}
//return globalsum;