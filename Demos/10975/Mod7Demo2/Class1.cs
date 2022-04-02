using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo2
{
    abstract class absClass
    {
        public int Prop1 { get; set; }
        public void NormalMethod()
        {
            //logic
        }
        public virtual void VirtualMethod()
        {
            //logic
        }
        public abstract void AbstractMethod(); //no logic. when you derive a class with abstract method it must be called
    }

    class A:absClass
    {
        // public abstract void Method1(); //abstract methods can only belong to abstract classes
        public override void VirtualMethod()
        {
            base.VirtualMethod();
        }
        public override void AbstractMethod()
        {
            // throw new NotImplementedException();
            //give desired logic
        }
    }
}
