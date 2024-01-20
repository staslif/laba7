using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку с избыточными пробелами:");
        string input = Console.ReadLine();
        // Удаление избыточных пробелов
        string output = Regex.Replace(input, @"\s+", " ");
        // Вывод результата
        Console.WriteLine("Результат:");
        Console.WriteLine(output);
    }
}
