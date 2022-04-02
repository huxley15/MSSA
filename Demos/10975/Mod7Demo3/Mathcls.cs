using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo3
{
    class Mathcls
    {
        //static polymorphism
        public int Addnumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Addnumbers(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public float Addnumbers(float num1, float num2)
        {
            return num1 + num2;
        }
    }
}
