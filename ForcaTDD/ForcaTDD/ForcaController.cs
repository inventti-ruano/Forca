using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForcaTDD
{
    class ForcaController
    {
        private string palavraResposta;
        private int quantidadeErros;
        private List<char> letrasJaInformadas;
        private char[] palavraFormada;
        private string p;

        public ForcaController()
        {
            this.IniciarJogo();
        }

        private void IniciarJogo()
        {
            this.palavraResposta = SorteioPalavra.RetornaPalavraSorteada();
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

        private void AtribuirPosicaoDasLetrasNaPalavra(char letra)
        {
            for (int i = 0; i < this.palavraResposta.Length; i++)
            {
                if (this.palavraResposta[i] == letra)
                {
                    this.palavraFormada[i] = letra;
                }
            }
        }

        public int RetornaQuantidadeErros()
        {
            return this.quantidadeErros;
        }

        public bool FinalizouJogo()
        {
            return !this.palavraFormada.Contains(default(char)) || this.quantidadeErros > 5;
        }

        private char TratarMaiusculaMinuscula(char letra)
        {
            return char.ToUpper(letra);
        }

        public string RetornarDesenhoForca()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < this.palavraFormada.Length; i++)
            {
                sb.Append(this.palavraFormada[i] != '\0' ? this.palavraFormada[i].ToString() : "_").Append(" ");
            }
            return sb.ToString().Trim();
        }

        public bool RetornarVitoria()
        {
            return !this.palavraFormada.Contains(default(char)) && this.quantidadeErros < 6;
        }
    }
}