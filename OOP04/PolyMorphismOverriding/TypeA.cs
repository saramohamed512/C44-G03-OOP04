using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.PolyMorphismOverriding
{
    public class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }
        public void Func01() { 
            Console.WriteLine("Parent Class");
        }
        public virtual void Func02()
        {
            Console.WriteLine($"type A: {A}");
        }
    }
}
