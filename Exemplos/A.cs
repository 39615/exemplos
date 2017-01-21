using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    public abstract class A : I
    {
        public abstract int contas(int a, int b);

        public int idade()
        {
            return 20;
        }

        public string nome()
        {
            return "Um Nome qualquer";
        }
    }
}
