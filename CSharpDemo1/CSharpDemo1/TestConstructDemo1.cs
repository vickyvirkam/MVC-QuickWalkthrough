using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo1
{
    class TestConstructDemo1
    {
        static void Main()
        {
            ConstructorDemo1 cd1 = new ConstructorDemo1(10,20);
            cd1.Add();
            cd1.Div();
            cd1.Sub();
            cd1.Mul();
            Console.ReadLine();
        }
    }
}
