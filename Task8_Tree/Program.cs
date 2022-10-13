// Пройти по Бинарному дереву представленому в виде массива: ((2-4)*(1+3))/10
// {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"}
//   0    1    2    3     4    5    6    7    8    9    10   11

string emp = string.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
void InOrderTraversal(int pos = 1) // указывается позиция с кот начинаем обход
{
    if (pos < tree.Length) 
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // !String.IsNullOrEmpty(tree[left] - элемент не явл пустым
        System.Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();