Console.Clear();
Console.WriteLine("В двумерном массиве n*k заменить четные элементы на противоположные");
Console.Write("Введите количество столбцов: ");
int sizeColumn = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк: ");
int sizeRow =  int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[sizeRow,sizeColumn];

for (int i=0; i<sizeRow; i++)
    for (int j=0; j<sizeColumn; j++)
        array[i,j] = new Random().Next(0,10);

for (int i=0; i<sizeRow; i++)
    for (int j=0; j<sizeColumn; j++)
        if (array[i,j]%2 == 0)
            array[i,j] = -array[i,j];

for (int i=0; i<sizeRow; i++)
{
    Console.WriteLine();
    for (int j=0; j<sizeColumn; j++)
        Console.Write($"{array[i,j]} ");
}