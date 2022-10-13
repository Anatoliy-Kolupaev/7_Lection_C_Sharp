// Собрать строку с числами от а до b, a <= b , 2 способа интерактивный и рекурсия

string NumbersFor (int a, int b) // Интерактивный
{
    string result = string.Empty; // пустая строка
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec (int a, int b) // Рекурсия
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}
Console.WriteLine(NumbersFor (1, 10));
Console.WriteLine(NumbersRec (1, 10));