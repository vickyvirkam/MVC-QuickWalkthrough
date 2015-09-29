using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo1
{
    class MyOutPutParam
    {
        static void Main()
        {
            Program P = new Program();
            int a = 20, b = 0, c = 0, d = 0;
            P.OperationNums(a,b,ref c,ref d);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();
        
        }
    }
}
