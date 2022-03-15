using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatischeSpullen
{
    internal static class StaticClass
    {
        public static string SponsoredBy(this string s)
        {
            return $"{s} is sponsored by me";
        }
    }
}
