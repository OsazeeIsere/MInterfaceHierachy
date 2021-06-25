using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MInterfaceHierachy
{
    class Rectangle:IShape
    {
        //explicit interface implementation
         void IDrawable.Draw()
         {
            Console.WriteLine("Drawing to screen...");
         }
        void IPrintable.Draw() { Console.WriteLine("Draw to print.."); }
        public int GetNoSides()
        {
            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Printing ...");
        }
    }
}
