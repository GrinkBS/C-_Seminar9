// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

if (M<N)
{
PrintNumbersMToN(N,M);
}
else
{
    Console.WriteLine("M > N");
}

void PrintNumbersMToN(int n, int m)
{
    if (n < m) return;
    PrintNumbersMToN(n-1, m);
    Console.Write(n + " ");
}