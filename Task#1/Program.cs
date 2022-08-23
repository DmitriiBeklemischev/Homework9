// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

void GetNumber(int m, int n)
{
    if (m < n + 1)
    {
        Console.Write($" {m},");
        m++;
        GetNumber(m, n);
    }

}


Console.WriteLine("Введите число М");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

if (m < n)
{
    GetNumber(m, n);
}
else
{
    GetNumber(n, m);
}
