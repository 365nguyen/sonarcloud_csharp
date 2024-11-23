using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AccountRespository
    {
        public int Add(int a, int b) {
            string apiKey = "jadfijadjalfdukukel";
            return a + b;
        }

        [ExcludeFromCodeCoverage]
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
