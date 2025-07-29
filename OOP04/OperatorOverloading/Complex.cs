using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.OperatorOverloading
{
    public class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        #region Operator Overloading
        public static Complex operator +(Complex C1, Complex C2)
        {
            return new Complex()
            {
                Real = (C1?.Real??0) + (C2?.Real??0),
                Imag = (C1?.Imag??0) + (C2?.Imag ?? 0)
            };
        }
        public static Complex operator -(Complex C1, Complex C2)
        {
            return new Complex()
            {
                Real = (C1?.Real ?? 0) - (C2?.Real ?? 0),
                Imag = (C1?.Imag ?? 0) - (C2?.Imag ?? 0)
            };
        }
        public static Complex operator ++(Complex C1)
        {
            return new Complex()
            {
                Real = (C1?.Real ?? 0) + 1,
                Imag = (C1?.Imag ?? 0) + 1
            };
        }
        public static bool operator >(Complex C1, Complex C2)
        {
            if(C2.Real == C1.Real)
            {
                return C1.Imag > C2.Imag;
            }
            else
            {
                return C1.Real > C2.Real; 
            }

        }
        public static bool  operator <(Complex C1, Complex C2)
        {
            if (C2.Real == C1.Real)
            {
                return C1.Imag < C2.Imag;
            }
            else
            {
                return C1.Real < C2.Real;
            }

        }

        #endregion
        #region Casting Operator Overloading
        public static explicit operator int(Complex c)
        {
            return c?.Real??0;
        }
        public static implicit operator string(Complex c)
        {
           return c?.ToString() ?? string.Empty;
        }
        #endregion

    }
}
