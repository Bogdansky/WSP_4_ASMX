using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Client
{
    public class A
    {
        public string S { get; set; }
        public int K { get; set; }
        public float F { get; set; }

        public static explicit operator SimplexReference.A(A obj)
        {
            return new SimplexReference.A
            {
                S = obj.S ?? string.Empty,
                K = obj.K,
                F = obj.F
            };
        }
    }
}
