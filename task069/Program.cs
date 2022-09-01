// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowAtoB(A,B));

int PowAtoB(int a, int b)
{
    if (b <=0) return 1;
    return a * PowAtoB(a, b - 1);
}