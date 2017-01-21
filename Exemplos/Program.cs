using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    class Program
    {

        static void Main(string[] args)
        {
            /*I sum = new Soma();
            I sub = new Subtraccao();
            I mul = new Multiplicacao();

            int a = 2;
            int b = 1;

            Console.WriteLine(sum.nome());
            Console.WriteLine(sum.idade());
            Console.WriteLine(sum.contas(a, b));

            Console.WriteLine("----------------------------");

            Console.WriteLine(sub.nome());
            Console.WriteLine(sub.idade());
            Console.WriteLine(sub.contas(a, b));

            Console.WriteLine("----------------------------");

            Console.WriteLine(mul.nome());
            Console.WriteLine(mul.idade());
            Console.WriteLine(mul.contas(a, b));

            Console.ReadKey();*/

            Action x = () => Console.WriteLine("mensagem");

            Func<int, int, int> z = w;

            Console.WriteLine( z(1, 2) );

            Teste.showBox( x );

            Console.ReadKey();
        }


        static int w(int a, int b)
        {
            return a+b;
        }
    }
}
