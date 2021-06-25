using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MInterfaceHierachy
{
    //multiple interface inheritance.ok! 
    interface IShape:IDrawable,IPrintable
    {
        int GetNoSides();
    }
}
