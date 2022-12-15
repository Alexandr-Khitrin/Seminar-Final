
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
NaturalNumber(number);

void NaturalNumber(int number)
{
    if (number < 0)
    {
        Console.WriteLine("Вы ввели не натуральное число");
        return;
    }    
    if (number == 0) return;
    Console.Write(number + " ");
    NaturalNumber(number - 1);
}