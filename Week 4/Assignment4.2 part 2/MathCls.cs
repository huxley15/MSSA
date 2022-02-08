using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2_part_2
{
    internal class MathCls
    {
        
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Add(int num1, int num2, int num3)
        {
            return num1+num2 + num3;
        }

        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }
}
