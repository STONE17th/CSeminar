Console.Clear();
Console.WriteLine("Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов");
Console.Write("Введите количество строк: ");
int sizeCol = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int sizeRow = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[sizeCol,sizeRow];
double Summa = 0;
var rnd = new Random();

for (int i=0; i<sizeCol; i++)
{
    for (int j=0; j<sizeRow; j++)
    {
        matrix[i,j] = rnd.Next(0,100);
        Console.Write($"{matrix[i,j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i=0; i<sizeRow; i++)
{
    Summa=0;
    for (int j=0; j<sizeCol; j++)
        Summa += matrix[j,i];
    Console.WriteLine($"Среднее арифметическое {i+1} столбца: {Math.Round(Summa/sizeCol, 2)} ");
}
