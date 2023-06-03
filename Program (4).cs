using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proposta_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limitemax;
            int limitemin;
            int oculto;
            int jogador;
            int palpite;
            int njog;

            Console.WriteLine("digite a quantia de jogadores: ");
            njog = int.Parse(Console.ReadLine());

            // oculto

            do
            {
                Console.WriteLine("digite o valor oculto");
                oculto = int.Parse(Console.ReadLine());
            }
            while (oculto < 1 && oculto > 100);
            
                Console.Clear();

                limitemax = 100;
                limitemin = 1;

            jogador = 1;

            do
            {
                Console.WriteLine("jogador {0} digite um valor inteiro entre {1} e {2}", jogador, limitemin, limitemax);
                palpite = int.Parse(Console.ReadLine());

                //condição



                if (palpite == oculto)
                    Console.WriteLine("voce perdeu :D");
                else
                    if (palpite < limitemin || palpite > limitemax)
                {
                    do
                    {
                        Console.WriteLine("digite um valor valido");
                        palpite = int.Parse(Console.ReadLine());
                    }
                    while (palpite < limitemin || palpite > limitemax);

                }
                else
                    if (palpite > oculto)
                    limitemax = palpite;
                else
                    limitemin = palpite;

                jogador = jogador + 1;
                if (jogador > njog)
                    jogador = 1;
            }
            while (palpite != oculto);
                    
















        }
    }
}
