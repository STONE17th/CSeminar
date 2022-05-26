Console.Clear();
Console.WriteLine("Показать числа Фибоначчи меньше заданного числа N");
Console.Write("Введите предел N: ");
int NumberN =  int.Parse(Console.ReadLine() ?? "0");

int NumFib1 = 0, NumFib2 = 1;
Console.Write($"{NumFib1} {NumFib2} ");
while(NumFib1 + NumFib2 <= NumberN)
{
    NumFib2 = NumFib1 + NumFib2;
    NumFib1 = NumFib2 - NumFib1;
    Console.Write($"{NumFib2} ");
}