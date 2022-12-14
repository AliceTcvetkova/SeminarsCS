// Напишите программу для нахождения максимального числа ягод, 
// которое может собрать за один заход собирающий модуль, 
// находясь перед некоторым кустом заданной во входном файле грядки.

//Console.Clear();
//Console.WriteLine("Введите количество кустов: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество ягод на грядке: ");
//int sum = 0;
//int max = 0;
//int a = 0;
//for (int i = 1; i <= n; i++)
//{
//    a = Convert.ToInt32(Console.ReadLine());
//    if (i < n - 1)
//    {
//        for (int j = 1; j < 4; j++)
//      {
//            sum = sum + a;
//        }
//    }
//    if (i = n - 1)

//    if (sum > max)
//        max = sum;
//}
//Console.WriteLine($"Максимальное количество ягод на грядке: {max}");
Console.Clear();
int maxSubArray(int [arr]){
    int localsum = 0;
    int globalsum = int.MinValue;
    for (int i = 1; i < arr.Length; i++){
        localsum = Math.Max(arr[i], arr[i] + localsum);
        globalsum = Math.Max(globalsum, localsum);
    }
}
return globalsum;