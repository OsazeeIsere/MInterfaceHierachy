using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MInterfaceHierachy
{
    interface IPrintable
    {
        void Print();
        void Draw();//<-- possible name clash
        
    }
}
