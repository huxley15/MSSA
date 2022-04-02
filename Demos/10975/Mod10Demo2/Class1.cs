using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10Demo2
{
    class Class1:IDisposable
    {
        ~Class1() //nondeterministic
        {
            //cleaning 
        }

        public void Dispose() //deterministic
        {
            GC.SuppressFinalize(this);
            //cleaning unmanaged resources
            throw new NotImplementedException();
        }
    }
}
