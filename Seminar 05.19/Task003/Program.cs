Console.Clear();
Console.WriteLine("Найти сумму чисел одномерного массива стоящих на нечетной позиции");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[arrSize];

Console.WriteLine("Массив: ");
for (int i=0; i<arrSize; i++)
{
    array[i] = new Random().Next(-10,10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine("");

int summa = 0;
for (int i = 0; i<arrSize; i += 2)
    summa += array[i];

Console.WriteLine($"Сумма элементов массива: {summa}");