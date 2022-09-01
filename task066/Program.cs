// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

int res = SumNCount(N,M);
if (M<N)
{
Console.WriteLine(res);
}
else
{
Console.WriteLine("Введены неверные параметры");
}
int SumNCount(int n, int m)
{
    if (n < m) return 0;
    return n + SumNCount(n - 1, m);
}

