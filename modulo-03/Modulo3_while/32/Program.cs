﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
                // Exibir a os 20 primeiros termos da Sequência de Bergamaschi.
{
    class Program
    {
        static void Main(string[] args)
        {
            int BnAnt3, BnAnt2, BnAnt, Bn, n;

            BnAnt3 = 1;
            BnAnt2 = 1;
            BnAnt = 1;
            n = 4;

            Console.WriteLine("Sequencia de Bergamaschi");
            Console.WriteLine();
            Console.WriteLine("1º - {0}", BnAnt3);
            Console.WriteLine("2º - {0}", BnAnt2);
            Console.WriteLine("3º - {0}", BnAnt);

            while (n <= 20)
            {
                Bn = BnAnt3 + BnAnt2 + BnAnt;
                BnAnt3 = BnAnt2;
                BnAnt2 = BnAnt;
                BnAnt = Bn;
                Console.WriteLine("{0}º - {1}", n, Bn);
                n++;
            }

            Console.ReadKey();
        }
    }
}
