Console.Clear();
Console.WriteLine("В двумерном массиве показать позицию числа, заданного пользователем"
    +"или указать, что такого элемента нет");
Console.Write("Введите количество столбцов: ");
int sizeColumn = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк: ");
int sizeRow =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите искомое число: ");
int Number =  int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[sizeRow,sizeColumn];
bool isHas = false;

for (int i=0; i<sizeRow; i++)
    for (int j=0; j<sizeColumn; j++)
        array[i,j] = new Random().Next(0,10);


for (int i=0; i<sizeRow; i++)
{
    Console.WriteLine();
    for (int j=0; j<sizeColumn; j++)
        Console.Write($"{array[i,j]} ");
}

Console.WriteLine();

for (int i=0; i<sizeRow; i++)
    for (int j=0; j<sizeColumn; j++)
        if (array[i,j] == Number)
        {
            Console.WriteLine($"Число {Number} есть в заданном массиве в {i+1} строке, в {j+1} столбце");
            isHas = true;
        }
if (!isHas) Console.WriteLine($"Числа {Number} нет в заданном массиве");