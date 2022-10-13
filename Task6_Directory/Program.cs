string path = "/Users/комп/Desktop/Seminar_C_Sharp_8";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime); // команда получить время и дату создания
FileInfo[] fi = di.GetFiles(); // команда показывает какие файлы там содержатся
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);    
}

void CatalogInfo (string path, string indent = " ") // пуль к папке и делать отступы для того чтобы видеть структуру папки
{
    DirectoryInfo catalog = new DirectoryInfo(path); // получаем информаци о деректории (создаем)
    DirectoryInfo[] catalogs = catalog.GetDirectories(); // получаем массив всех файлов в директории
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent} {catalogs[i].Name}"); // выводим информацию о текущем каталоге
        CatalogInfo(catalogs[i].FullName, indent + " "); // будем рекурсивно смотреть все папки в директории
    }
    FileInfo[] files = catalog.GetFiles(); // получим весь список файлов текущей директории
    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}"); // покажем все файлы
    }
}
CatalogInfo(path);