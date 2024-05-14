using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
                Console.WriteLine("Os ´números são iguais = {0}", n1);
            else

            if (n1>n2)
                Console.WriteLine("O primeiro número é o maior = {0}", n1);
            else
                Console.WriteLine("O segundo número é o maior = {0}", n2);

        }
    }
}
