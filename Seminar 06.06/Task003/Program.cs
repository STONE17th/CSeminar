Console.Clear();
Console.WriteLine("Показать факториал числа N, N задано");
Console.Write("Введите число N: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");

int N = 1;
int Fact = 1;

void factorial (int NumberN, int N, int Fact)
{
    if (N<=NumberN)
    {
        Fact *= N;
        N++;
        factorial(NumberN, N, Fact);
    }
    else
        Console.Write($"Факториал числа {NumberN}: {Fact}"); 
}

factorial(NumberN, N, Fact);