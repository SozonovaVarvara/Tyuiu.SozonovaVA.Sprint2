using Tyuiu.SozonovaVA.Sprint2.Task6.V5.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();



        Console.Title = "Спринт #2 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        //Длина строки 75 символов
        Console.WriteLine("****************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                            *");
        Console.WriteLine("* Тема: Операции сравнения                                                             *");
        Console.WriteLine("* Задание #6                                                                           *");
        Console.WriteLine("* Вариант #5                                                                           *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                                  *");
        Console.WriteLine("****************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                             *");
        Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch,    *");
        Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                                 *");
        Console.WriteLine("****************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
        Console.WriteLine("****************************************************************************************");


        Console.WriteLine("Введите номер карты:");
        int x = Convert.ToInt32(Console.ReadLine());








        Console.WriteLine("****************************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
        Console.WriteLine("****************************************************************************************");

        string res = ds.FindCardValue(x);
        Console.WriteLine(res);


        Console.ReadLine();
    }
}