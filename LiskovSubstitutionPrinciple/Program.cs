using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmw b = new Bmw();
            Console.WriteLine(b.Start());
            Console.WriteLine(b.Ac());

            Mercedes m = new Mercedes();
            Console.WriteLine(m.Start());
            Console.WriteLine(m.Ac());

            Tofas t = new Tofas();
            Console.WriteLine(t.Start());

            Console.ReadLine();
        }
    }
}
