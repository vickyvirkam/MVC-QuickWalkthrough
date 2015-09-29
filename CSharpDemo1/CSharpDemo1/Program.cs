using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo1
{
    class Program
    {

        public void OperationNums(int a, int b, ref int c, ref int d)
        {
            c = a + b;
            d = a * b;
        
        }

        static void Main(string[] args)
        {
            Program cd = new Program();
            int a=10, b=20, c=0, d=0;
            cd.OperationNums(a, b, ref c, ref d);
            Console.WriteLine(c + "" + d);
            Console.ReadLine();


        }
    }
}
