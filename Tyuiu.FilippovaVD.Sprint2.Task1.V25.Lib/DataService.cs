using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FilippovaVD.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a - 100 < b) & (c > d);
            res[2] = (a - 100 > b) || (c < d);
            res[3] = (a - 100 > b) && (c < d);
            res[4] = !res[1];
            res[5] = (a > b) ^ (c < d);

            return res;
            
        }
    }
}
