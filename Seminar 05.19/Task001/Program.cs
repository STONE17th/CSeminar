Console.Clear();
Console.WriteLine("Написать программу замену элементов массива на противоположные");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[arrSize];

Console.WriteLine("Оригианльный массив: ");
for (int i=0; i<arrSize; i++)
{
    array[i] =  new Random().Next(-100,100);
    Console.Write($"{array[i]} ");
    int g = 9;
}

Console.WriteLine("");  
Console.WriteLine("Противоположный массив: ");

for (int i=0; i<arrSize; i++)
{
    array[i] = -array[i];
    Console.Write($"{array[i]} ");
}
