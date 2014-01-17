using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForcaTDD
{
    class Mensagens
    {
        public static void PerguntarLetra()
        {
            Console.WriteLine("Informe uma letra.");
        }

        public static void LetraInexistente()
        {
            Console.WriteLine("A letra informada não existe na palavra. Tente outra.");
        }

        public static void LetraJaInformada()
        {
            Console.WriteLine("A letra informada já foi adicionada. Tente outra.");
        }

        public static void MostrarVitoria()
        {
            Console.WriteLine("Parabéns, você encontrou a palavra.");
        }

        public static void MostrarDerrota()
        {
            Console.WriteLine("Você foi enforcado.");
        }

        public static void MostrarQuantidadeErros(int qtd)
        {
            Console.WriteLine("Você possui {0} de 6 chances.", qtd);
        }
    }
}