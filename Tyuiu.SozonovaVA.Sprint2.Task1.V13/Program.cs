using Tyuiu.SozonovaVA.Sprint2.Task1.V13.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService service1 = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Созонова В. А. | АСОиУб-25 -1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логичесие операции                                                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
        Console.WriteLine("*последовательность операций не должна нарушаться) и арифметических       *");
        Console.WriteLine("*выражений, которая вернет логическую последовательность(массив):         *");
        Console.WriteLine("*(False, True, True, True, True, False),), при x = 3105, y = 77           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int a = 145;
        int b = 916;
        int c = 164;
        int d = 137;
        bool[] res = new bool[6];

        Console.WriteLine("a=" + a);
        Console.WriteLine("b=" + b);
        Console.WriteLine("c=" + c);
        Console.WriteLine("d=" + d);
        res = service1.GetLogicOperations(a, b, c, d);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}
