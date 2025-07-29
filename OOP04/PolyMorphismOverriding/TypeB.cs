using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.PolyMorphismOverriding
{
    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        public new void  Func01()
        {
            Console.WriteLine("Child Class");
        }

        public  override void Func02()
        {
            Console.WriteLine($"type B: B:{B} , A:{A}");
        }

    }
}
