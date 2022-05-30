Console.Clear();
Console.WriteLine("В матрице чисел найти сумму элементов главной диагонали");
Console.Write("Введите размер квадратной матрицы: ");
int size = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[size,size];
int summa = 0;
var rnd = new Random();

for (int i=0; i<size; i++)
{
    for (int j=0; j<size; j++)
        matrix[i,j] = rnd.Next(0,10);
    summa += matrix[i,i];
}

Console.WriteLine($"Квадратная матрица {size}х{size}");
for (int i=0; i<size; i++)
{
    for (int j=0; j<size; j++)
        Console.Write($"{matrix[i,j]}\t");
    Console.WriteLine();
}

Console.Write($"Сумма элементов главной диагонали: {summa}");