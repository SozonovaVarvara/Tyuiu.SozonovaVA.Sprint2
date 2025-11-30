using Tyuiu.SozonovaVA.Sprint2.Task3.V23.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2"                                                                );
        Console.WriteLine("* Тема: Вложенные операторы if - else"                                      );
        Console.WriteLine("* Задание #3"                                                               );
        Console.WriteLine("* Вариант #23"                                                              );
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                      ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:Написать программу, которая вычисляет требуемое значение функции Y с использованием " +
            "вложенных оператор if-else, где пользователь вводит значение переменной X с клавиатуры. " +
            "Округлить полученное значение до трех знаков после запятой;");
        Console.WriteLine("");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();
        Console.WriteLine("Введите x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x));
    }
}