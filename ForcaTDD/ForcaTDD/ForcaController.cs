using System.Collections.Generic;
using System.Linq;

namespace ForcaTDD
{
    class ForcaController
    {
        private string palavraResposta;
        private int quantidadeErros;
        private List<char> letrasJaInformadas;
        private char[] palavraFormada;

        public ForcaController(string palavra)
        {
            this.IniciarJogo(palavra);
        }

        private void IniciarJogo(string palavra)
        {
            this.palavraResposta = palavra;
            this.letrasJaInformadas = new List<char>();
            this.palavraFormada = new char[this.palavraResposta.Length];
            this.quantidadeErros = 0;
        }

        public bool ValidarSeLetraContemNaPalavra(char letra)
        {
            letra = TratarMaiusculaMinuscula(letra);
            var contemLetra = palavraResposta.Contains(letra);

            if (!contemLetra)
            {
                this.quantidadeErros++;
            }
            else
            {
                this.letrasJaInformadas.Add(letra);
                this.AtribuirPosicaoDasLetrasNaPalavra(letra);
            }
            return contemLetra;
        }

        public bool VerificarLetraInformadaJaExiste(char letra)
        {
            var jaExiste = this.letrasJaInformadas.Contains(this.TratarMaiusculaMinuscula(letra));
            if (jaExiste)
                this.quantidadeErros++;

            return jaExiste;
        }

        public char[] AtribuirPosicaoDasLetrasNaPalavra(char letra)
        {
            for (int i = 0; i < this.palavraResposta.Length; i++)
            {
                if (this.palavraResposta[i] == letra)
                {
                    this.palavraFormada[i] = letra;
                }
            }
            return this.palavraFormada;
        }

        public bool FinalizouJogo()
        {
            return !this.palavraFormada.Contains(default(char)) || this.quantidadeErros > 5;
        }

        public char TratarMaiusculaMinuscula(char letra)
        {
            return char.ToUpper(letra);
        }
    }
}