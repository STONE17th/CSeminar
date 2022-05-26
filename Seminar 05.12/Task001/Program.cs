Console.WriteLine("Задание. Дано число. Проверить кратно ли оно 7 и 23");
Console.Write("ВВедите любое число: ");
int Number = int.Parse(Console.ReadLine() ?? "0");
if (Number % 7 == 0 && Number % 23 == 0)
    {
        Console.Write($"Число {Number} - кратно 7 и 23");
    }
else
    {
        Console.Write($"Число {Number} - корявое :)");
    }