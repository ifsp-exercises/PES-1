﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
                //Exibir os 30 primeiros elementos da sequencia de Fibinacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int FnAnt2, FnAnt, Fn;
            FnAnt2 = 1;
            FnAnt = 1;

            Console.WriteLine("Sequência Fibonacci");
           // Console.WriteLine();
            Console.WriteLine("1º - {0}", FnAnt2);
            Console.WriteLine("2º - {0}", FnAnt);

            for (int n=3; n<=30; n++)
            {
                Fn = FnAnt2 + FnAnt;
                FnAnt2 = FnAnt;
                FnAnt = Fn;
                Console.WriteLine("{0}º - {1}", n, Fn);
            }

          //  Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}