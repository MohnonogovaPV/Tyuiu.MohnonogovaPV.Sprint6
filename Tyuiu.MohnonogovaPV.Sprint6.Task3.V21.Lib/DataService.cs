using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.MohnonogovaPV.Sprint6.Task3.V21.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint6.Task3.V21.Lib
{
    public class DataService : ISprint6Task3V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] oneColumn = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                oneColumn[i] = matrix[i, 0];
            }
            Array.Sort(oneColumn);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = oneColumn[i];
            }
            return matrix;
        }
    }
}
