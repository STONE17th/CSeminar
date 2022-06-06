Console.Clear();
Console.WriteLine("Показать натуральные числа от 1 до N, N задано");
Console.Write("Введите число N: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");

int N = 1;
PrintNaturalNumbers(N);

void PrintNaturalNumbers (int N)
{
    if (N<=NumberN)
    {
        Console.Write($"{N} ");
        N++;
        PrintNaturalNumbers(N);
    }
}

// Console.WriteLine();
// void PrintNumber(int n)
// {
//     if(n<1)return;
//     PrintNumber(n-1);
//     Console.Write (n + " ");
// }
// PrintNumber(10);