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
        public void usuario_escolhe_uma_letra_e_erra()
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

        public void verificar_se_a_mesma_letra_foi_informada_mais_de_uma_vez()
        {
            var forca = new ForcaController("teste");
        }

        public void validar_se_encerrou_o_jogo()
        {
            
        }
    }
}
