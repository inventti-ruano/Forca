using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ForcaTDD.Testes
{
    class SorteioPalavraTeste
    {
        [Test]
        public void validar_uma_palavra_do_sorteio()
        {
            string palavraSorteada;
            List<string> retornoListaSorteada = null;
            retornoListaSorteada = SorteioPalavra.RetornarListaDePalavras();
            palavraSorteada = retornoListaSorteada[0];

            Assert.AreEqual(palavraSorteada, "BLUMENAU");
        }
    }
}