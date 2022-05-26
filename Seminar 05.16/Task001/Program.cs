Console.WriteLine("Показать таблицу квадратов чисел от 1 до N");
Console.Write("Введите число: ");
int Number =  int.Parse(Console.ReadLine() ?? "0");

int i = 1;
int SqrN = 0;
while (i <= Number)
{
    Console.Write($"  {i}  ");
    i++;
}
Console.WriteLine("");
i =1;
while (i <= Number)
{
    SqrN = i*i;
    Console.Write($"  {SqrN}  ");
    i++;
}


