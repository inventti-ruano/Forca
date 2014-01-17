using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForcaTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var forca = new ForcaController();
            Console.WriteLine("-- JOGO DA FORCA --");
            Console.WriteLine();

            while (!forca.FinalizouJogo())
            {
                Console.WriteLine();
                DesenharForca(forca);
                Console.WriteLine();
                Mensagens.PerguntarLetra();
                Console.Write("Letra: ");
                var letraInformada = char.Parse(Console.ReadLine());

                while (forca.VerificarLetraInformadaJaExiste(letraInformada))
                {
                    if (forca.RetornaQuantidadeErros() == 6)
                    {
                        break;
                    }
                    Console.Clear();
                    Mensagens.LetraJaInformada();
                    MostrarQuantidadeErros(forca);
                    DesenharForca(forca);
                    Console.WriteLine();
                    Console.Write("Letra: ");
                    letraInformada = char.Parse(Console.ReadLine());
                }

                while (!forca.ValidarSeLetraContemNaPalavra(letraInformada))
                {
                    if (forca.RetornaQuantidadeErros() == 6)
                    {
                        break;
                    }
                    Console.Clear();
                    Mensagens.LetraInexistente();
                    MostrarQuantidadeErros(forca);
                    DesenharForca(forca);
                    Console.WriteLine();
                    Console.Write("Letra: ");
                    letraInformada = char.Parse(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine();
                MostrarQuantidadeErros(forca);
            }
            if (forca.RetornarVitoria())
            {
                Mensagens.MostrarVitoria();
            }
            else
            {
                Mensagens.MostrarDerrota();
            }
            Console.ReadKey();
        }

        private static void DesenharForca(ForcaController forca)
        {
            Console.WriteLine(forca.RetornarDesenhoForca());
        }

        private static void MostrarQuantidadeErros(ForcaController forca)
        {
            if (forca.RetornaQuantidadeErros() < 7) {
                Console.WriteLine();
                Mensagens.MostrarQuantidadeErros(6 - forca.RetornaQuantidadeErros());
                Console.WriteLine();
            }
        }
    }
}