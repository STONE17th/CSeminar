Console.Clear();
Console.WriteLine("Написать программу преобразования десятичного числа в двоичное");
Console.Write("Введите число десятичной системе: ");
int NumberN =  int.Parse(Console.ReadLine() ?? "0");
int i = 0;
int Number = NumberN;
while (Number>0)
{
    Number /= 2;
    i++;
}

int[] array = new int[i];

i = 0;

while (NumberN>0)
{
    if (NumberN%2 == 0)
        array[i] = 0;
    else
        array[i] = 1;
    NumberN /= 2;
    i++;
}
Console.Write($"Число в двоичной системе: ");
for (int k = i-1; k>=0; k--)
    Console.Write($"{array[k]} ");
