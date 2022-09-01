// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9


Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

if (m>0 & n>0)
{
Console.WriteLine($"(A(m,n) = {AckermannFunc(m, n)})");
}
else
{
Console.WriteLine("m и n должны быть больше 0");
}
int AckermannFunc(int a, int b)
{
    if (a == 0)
        return b + 1;
    if (a > 0)
        if (b == 0)
            return AckermannFunc(a - 1, 1);
    return AckermannFunc(a - 1, AckermannFunc(a, b - 1));
}