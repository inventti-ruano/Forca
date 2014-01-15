using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ForcaTDD.Testes
{
    class ForcaControllerTeste
    {
        [Test]
        public void intancia_jogo_da_forca()
        {
            var forca = new ForcaController("bla");
        }

        [Test]
        public void usuario_escolhe_uma_letra_e_errar()
        {
            var forca = new ForcaController("bla");

            const char letraInvalida = 'x';
            bool acertou = forca.EscolherLetra(letraInvalida);

            Assert.IsFalse(acertou);
        }

        [Test]
        public void usuario_escolhe_uma_letra_e_acerta()
        {
            var forca = new ForcaController("bla");

            const char letraValida = 'a';
            bool acertou = forca.EscolherLetra(letraValida);

            Assert.IsTrue(acertou);
        }
    }
}
