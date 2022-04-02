using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo3
{
    class InvalidCardException:Exception
    {
        public override string Message => "Invalid Card";
    }
}
