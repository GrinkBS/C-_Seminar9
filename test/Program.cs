int n = 5;
int res = SumNCount(n);
Console.WriteLine(res);

int SumNCount(int number)
{
    if(number<1) return 0;
    return number + SumNCount (number -1);
}