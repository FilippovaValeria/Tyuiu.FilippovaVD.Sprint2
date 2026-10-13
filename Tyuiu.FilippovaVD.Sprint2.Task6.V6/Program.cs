using Tyuiu.FilippovaVD.Sprint2.Task6.V6.Lib;
namespace Tyuiu.FilippovaVD.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Филиппова Валерия Денисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданным номеру масти m (1-4) и номеру достоинства карты k (6-14)    *");
            Console.WriteLine("* определить полное название карты.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер достоинства: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string cardName = ds.FindCardNameAndValue(m, k);
            Console.WriteLine($"Название карты: {cardName}");

            Console.ReadLine(); 
        }
    }
}
