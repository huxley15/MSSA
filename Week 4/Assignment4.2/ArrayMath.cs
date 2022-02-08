using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    internal class ArrayMath
    {
        public int[,] ArraySum(int[,] array1, int[,] array2)
        {
            int row=array1.GetLength(0);
            int col=array1.GetLength(1);
            int[,] sumarray=new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sumarray[i,j] = array1[i,j] + array2[i,j];
                }
            }
            return sumarray;
        }
    }
}
