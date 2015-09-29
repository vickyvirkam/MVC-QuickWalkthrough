using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo1
{
    class Variables
    {
        int a;//instance
        static int sum;//static
        const float pi = 3.14f;
        readonly int abc;
        public Variables()
        {
            abc = 100;

        
        }
        static void Main()
        {
        Variables varbl = new Variables();
        Console.WriteLine("readonly:"+varbl.abc);
            Console.WriteLine("static:"+sum);
            Console.WriteLine("constant:"+pi);
            Console.WriteLine("instance:"+varbl.a);
            Console.ReadLine();
        
        }

    }
}
