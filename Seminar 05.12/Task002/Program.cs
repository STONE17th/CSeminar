Console.WriteLine("Задание. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0");
Console.Write("ВВедите координату X: ");
int CordX = int.Parse(Console.ReadLine() ?? "0");
Console.Write("ВВедите координату Y: ");
int CordY = int.Parse(Console.ReadLine() ?? "0");
if (CordX > 0)
    if (CordY > 0) Console.Write($"Координаты Х {CordX} и Y {CordY} во второй плокости");
    else Console.Write($"Координаты Х {CordX} и Y {CordY} в четвертой плокости");
else{
    if (CordY > 0) Console.Write($"Координаты Х {CordX} и Y {CordY} в первой плокости");
    else Console.Write($"Координаты Х {CordX} и Y {CordY} в третьей плокости");
}