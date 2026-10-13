using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FilippovaVD.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int m, int k)
        {
            if (m < 1 || m > 4) return "Некорректная масть";
            if (k < 6 || k > 14) return "Некорректное достоинство";

            string suit = m switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => "Неизвестно"
            };

            string rank = k switch
            {
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => "Неизвестно"
            };

            return $"{rank} {suit}";
        }
    }
}
