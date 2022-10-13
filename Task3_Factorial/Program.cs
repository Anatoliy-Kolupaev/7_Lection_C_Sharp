// Найти факториал числа n

int FactorialFor (int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result*=1;
    return result;
}

int FactorialRec (int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec (n - 1);
}
System.Console.WriteLine(FactorialFor(10));
System.Console.WriteLine(FactorialRec(10));