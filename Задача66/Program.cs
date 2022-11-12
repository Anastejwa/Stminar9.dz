// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumdersSumFromeBefor(int frome, int before)
{
    if (frome == before)
    {
        return before;
    }
    return frome + NumdersSumFromeBefor(frome + 1, before);
}
Console.Write("Введите число(от): ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число(до): ");
int n2 = int.Parse(Console.ReadLine()!);
int sum = NumdersSumFromeBefor(n1, n2);
Console.WriteLine(sum);
