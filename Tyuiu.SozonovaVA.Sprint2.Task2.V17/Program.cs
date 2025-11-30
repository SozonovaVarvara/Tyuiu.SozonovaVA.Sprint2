using Tyuiu.SozonovaVA.Sprint2.Task2.V17.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает целые значения                  *");
        Console.WriteLine("* с клавиатуры и вычисляет находится ли точка с координатами X,Y          *");
        Console.WriteLine("* в заштрихованной области.                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите X:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите Y:");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"X = {x}\nY = {y}");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool res = ds.CheckDotInShadedArea(x, y);
        if (res)
        {
            Console.WriteLine("Точка в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не в заштрихованной области");
        }


        Console.ReadKey();
    }
}