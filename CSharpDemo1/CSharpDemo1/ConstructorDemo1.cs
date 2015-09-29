using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo1
{
    class ConstructorDemo1
    {
        int a, b;
        public ConstructorDemo1(int a,int b)
        {
            this.a = a;
            this.b = b;
        
        }
        public void Add()
        {
            Console.WriteLine(a + b);
        
        }
        public void Sub()
        {
            Console.WriteLine(a - b);

        }

        public void Mul()
        {
            Console.WriteLine(a * b);

        }


        public void Div()
        {
            Console.WriteLine(a / b);

        }
    }
}
