using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FilippovaVD.Sprint2.Task5.V3.Lib
{
    public class DataService : ISprint2Task5V3
    {
        public string FindDayName(int dayNumber)
        {
            string result;

            switch (dayNumber)
            {
                case 1:
                    result = "понедельник";
                    break;
                case 2:
                    result = "вторник";
                    break;
                case 3:
                    result = "среда";
                    break;
                case 4:
                    result = "четверг";
                    break;
                case 5:
                    result = "пятница";
                    break;
                case 6:
                    result = "суббота";
                    break;
                case 7:
                    result = "воскресенье";
                    break;
                default:
                    result = "Некорректный номер дня недели";
                    break;
            }

            return result;
        }
    }
}
