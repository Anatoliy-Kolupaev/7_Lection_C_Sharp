// Перебор слов:
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в" 
// Покажите все слова, состоящие из Т букв, которые можно построить из
// букв этого алфавита

char [] s = {'а', 'и', 'с', 'в'};
int  count = s.Length;
int n = 1;
for (int i = 0; i < count; i++) // получатся однобуквенные слова
{
    System.Console.WriteLine($"{n++, -5} {s[i]}");
}
for (int i = 0; i < count; i++)  // Получатся двухбуквенные слова
{
    for (int j = 0; j < count; j++)
    {
        System.Console.WriteLine($"{n++, -5} {s[i]} {s[j]}");
    }
}
// для 3х буквенных и т.д слов необходимо больше циклов

int m = 1;
void FindWords (string alphabet, char [] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word) }"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords (alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);