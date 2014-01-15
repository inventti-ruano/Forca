using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForcaTDD
{
    class ForcaController
    {
        private readonly string palavra;

        public ForcaController(string palavra)
        {
            this.palavra = palavra;
        }

        public bool EscolherLetra(char letra)
        {
            return palavra.Contains(letra);
        }
    }
}
