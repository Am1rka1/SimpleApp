Console.Write("Введите первое число: ");
if (!double.TryParse(Console.ReadLine(), out double first))
{
    Console.WriteLine("Это не число.");
    return;
}

Console.Write("Введите второе число: ");
if (!double.TryParse(Console.ReadLine(), out double second))
{
    Console.WriteLine("Это не число.");
    return;
}

Console.WriteLine($"Сумма: {first + second}");
