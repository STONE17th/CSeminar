Console.WriteLine("Найти произведение чисел от 1 до А");
Console.Write("Введите число: ");
int NumberA =  int.Parse(Console.ReadLine() ?? "0");

int Num = 1;
for (int i = 1; i <= NumberA; i++)
    Num *= i;

Console.WriteLine($"Произведение чисел от 1 до {NumberA} равна {Num}");