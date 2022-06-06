Console.Clear();
Console.WriteLine("Показать натуральные числа от N до 1, N задано");
Console.Write("Введите число N: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");

PrintNaturalNumbers(NumberN);

void PrintNaturalNumbers (int N)
{
    if (N>=1)
    {
        Console.Write($"{N} ");
        N--;
        PrintNaturalNumbers(N);
    }
}

// Console.WriteLine();
// void PrintNumber(int n)
// {
//     if(n<1)return;
//     Console.Write (n + " ");
//     PrintNumber(n-1);
// }
// PrintNumber(10);