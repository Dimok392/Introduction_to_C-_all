// Как посмотреть содержимое папки?
void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
string path = @"E:\Geekbrains\4.Знакомство с языками программирования\Знакомство с языками программирования (лекции)\Урок 7. Рекурсия продолжение\Lesson 7. Recursion Continued\example\7.Как посмотреть содержимое папки";
CatalogInfo(path);
