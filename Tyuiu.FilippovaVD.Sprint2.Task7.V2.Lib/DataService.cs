using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FilippovaVD.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (y <= 0 && (x * x + y * y) <= 1 && y >= -x / 2.0)
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