Console.WriteLine("Найти сумму чисел от 1 до А");
Console.Write("Введите число: ");
int NumberA =  int.Parse(Console.ReadLine() ?? "0");

int summa = 0;
for (int i = 1; i <= NumberA; i++)
    summa += i;

Console.WriteLine($"Сумма чисел от 1 до {NumberA} равна {summa}");