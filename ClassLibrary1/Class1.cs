namespace ClassLibrary1;

public class Class1
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Добро пожаловать в калькулятор");
        Console.WriteLine("Введите первое число");
        int pervoechislo = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите *, /, + или -");
        string oprachia = Console.ReadLine();
        Console.WriteLine("Введите 2 число");
        int vtoroechislo = int.Parse(Console.ReadLine());
        if (oprachia == "+")
        {
            Console.WriteLine(pervoechislo + vtoroechislo);
        }
        if (oprachia == "-")
        {
            Console.WriteLine(pervoechislo - vtoroechislo);
        }
        if (oprachia == "*")
        {
            Console.WriteLine(pervoechislo * vtoroechislo);
        }
        if (oprachia == "/")
        {
            Console.WriteLine(pervoechislo / vtoroechislo);
        }
    }
}