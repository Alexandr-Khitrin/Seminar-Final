Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
NaturalSum(m, n, 0);
void NaturalSum (int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма элементов: {sum}");
        return;
    }
    sum = sum + m++;
    NaturalSum(m, n, sum);
}
