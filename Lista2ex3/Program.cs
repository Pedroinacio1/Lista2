using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lista2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;

            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 == n2 && n1 == n3)
                Console.WriteLine("todos os números são iguais");
            else
                if (n1 == n2 && n1 > n3)
                Console.WriteLine("o primeiro e o segundo número são iguais = {0}", n1);
            else
                if (n1 == n3 && n1 > n2) 
                Console.WriteLine("o primeiro e o terceiro número são iguais = {0}", n1);
            else
                if (n2 == n3 && n2 > n1)
                Console.WriteLine("o segundo e o terceiro número são iguais = {0}", n2);
            else
                if (n1 > n2 && n1 > n3)
                Console.WriteLine("O primeiro número é o maior = {0}", n1);
            else
                if (n2 > n1 && n2 > n3)
                Console.WriteLine("O segundo número é o maior = {0}", n2);
            else
                if (n3 > n2 && n3 > n1)
                Console.WriteLine("O terceiro número é o maior = {0}", n3);

        }
    }
}
