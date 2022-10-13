// Задача передвигать перамидку между 3мя шпилями
// string with = "1" - первый шпиль от куда мы должны взять блинчик
// string on = "3" - шпиль на котором пирамидка должна оказаться
// string some = "2" - промежуточный шпиль
// int count = 3 - кол- во блинчиков

void Towers (string with = "1", string on = "3", string some = "2", int count = 4)
{
    if (count > 1) Towers(with, some, on, count -1);
    System.Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count -1);
}
Towers();