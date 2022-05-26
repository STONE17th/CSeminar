Console.Clear();
Console.WriteLine("Выяснить являются ли три числа сторонами треугольника");
Console.Write("Введите первую сторону треугольника: ");
int ASide =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите вторую сторону треугольника: ");
int BSide =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите третью сторону треугольника: ");
int CSide =  int.Parse(Console.ReadLine() ?? "0");

if ((ASide+BSide>CSide) && (ASide+CSide>BSide) && (BSide+CSide>ASide))
    Console.WriteLine("Из данных отрезков можно построить треугольник");
else
    Console.WriteLine("Из данных отрезков треугольник не получится");

int MaxSide = ASide;

if (ASide>MaxSide)
{
    MaxSide = BSide;
    if (MaxSide*MaxSide == BSide*BSide + CSide*CSide)
        Console.WriteLine("Треугольник прямоугольный");
}
if (BSide>MaxSide)
{
    MaxSide = BSide;
    if (MaxSide*MaxSide == ASide*ASide + CSide*CSide)
        Console.WriteLine("Треугольник прямоугольный");
}
if (CSide>MaxSide)
{
    MaxSide = CSide;
    if (MaxSide*MaxSide == ASide*ASide + BSide*BSide)
        Console.WriteLine("Треугольник прямоугольный");
}