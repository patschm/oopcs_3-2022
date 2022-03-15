using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenen
{
    public struct Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public override string ToString()
        {
            return $"({Real} + {Imaginary}i)";
        }
    }
}
