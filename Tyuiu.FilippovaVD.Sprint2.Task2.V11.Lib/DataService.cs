using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FilippovaVD.Sprint2.Task2.V11.Lib
{
    public class DataService : ISprint2Task2V11
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (
                (x >= 3 && x <= 10 && y >= 3 && y <= 4) ||
                (x >= 8 && x <= 9 && y >= 3 && y <= 5) ||
                (x >= 5 && x <= 10 && y >= 5 && y <= 10) ||
                (x >= 5 && x <= 6 && y >= 10 && y <= 11) ||
                (x >= 9 && x <= 10 && y >= 10 && y <= 11) ||
                (x >= 11 && x <= 12 && y >= 5 && y <= 8) ||
                (x >= 3 && x <= 4 && y >= 6 && y <= 7) ||
                (x >= 7 && x <= 8 && y >= 11 && y <= 12)
               )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
