Console.Clear();
Console.WriteLine("Задать массив из 8 элементов и вывести их на экран");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[arrSize];

for (int i=0; i<arrSize; i++)
    array[i] =  new Random().Next(0,100);

int count = 1;

foreach (int k in array)
{
    Console.WriteLine($"{count} элемент массива - {k}");
    count++;
}