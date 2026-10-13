using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FilippovaVD.Sprint2.Task4.V15.Lib
{
    public class DataService : ISprint2Task4V15
    {
        public double Calculate(double x, double y)
        {
            double z = (Math.Sqrt(x) + 2 > Math.Cbrt(y) - 20)
                ? Math.Pow(3 + 2.0 / y, x)       
                : Math.Cos(y) + (12.0 / x);      

            return Math.Round(z, 3);
        }
    }
}
