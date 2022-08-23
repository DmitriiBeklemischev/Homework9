// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSumNumber(int m, int n, int sum)
{

    if (m < n + 1)
    {
        sum += m;
        m++;
        return GetSumNumber(m, n, sum);
    }
    return sum;
}

Console.WriteLine("Введите число М");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int sum = 0;

if (m < n)
{
    Console.WriteLine($"{GetSumNumber(m, n, sum)}");
}
else
{
    Console.WriteLine($"{GetSumNumber(n, m, sum)}");
}

