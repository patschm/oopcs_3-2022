using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generieken
{
    public class Complex<T> where T : struct
    {
        public T Real { get; set; }
        public T Imaginary { get; set; }

        //public static Complex<T> operator+(Complex<T> c1, Complex<T> c2)
        //{
        //    return new Complex<T> { Real = c1.Real + c2.Real, Imaginary = c1.Imaginary + c2.Imaginary };
        //}

        public override string ToString()
        {
            return $"({Real} + {Imaginary}i)";
        }
    }
}
