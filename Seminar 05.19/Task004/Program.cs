Console.Clear();
Console.WriteLine("В Указанном массиве вещественных "
    +"чисел найдите разницу между максимальным и минимальным элементом");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[arrSize];

Console.WriteLine("Массив: ");
for (int i=0; i<arrSize; i++)
{
    array[i] = new Random().Next(0,100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine("");

int ArrMin = array[0], ArrMax = array[0];

foreach (int k in array)
{
    if (ArrMin>k) ArrMin = k;
    if (ArrMax<k) ArrMax = k;
}

Console.WriteLine($"Разность максимального({ArrMax}) и "
    +$"минимального({ArrMin}) элементов массива равна "
    +$"{ArrMax - ArrMin}");