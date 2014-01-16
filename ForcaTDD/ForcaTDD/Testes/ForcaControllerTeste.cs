using NUnit.Framework;

namespace ForcaTDD.Testes
{
    class ForcaControllerTeste
    {
        [Test]
        public void intancia_jogo_da_forca()
        {
            var forca = new ForcaController("CARRO");
        }

        [Test]
        public void usuario_escolhe_uma_letra_e_erra()
        {
            var forca = new ForcaController("CARRO");

            const char letraInvalida = 'X';
            bool acertou = forca.ValidarSeLetraContemNaPalavra(letraInvalida);

            Assert.IsFalse(acertou);
        }

        [Test]
        public void usuario_escolhe_uma_letra_e_acerta()
        {
            var forca = new ForcaController("CARRO");

            const char letraValida = 'C';
            bool acertou = forca.ValidarSeLetraContemNaPalavra(letraValida);

            Assert.IsTrue(acertou);
        }

        [Test]
        public void letra_informada_jah_existe()
        {
            var forca = new ForcaController("CARRO");
            const char letraDigitadaPeloUsuario = 'C';
            forca.ValidarSeLetraContemNaPalavra(letraDigitadaPeloUsuario);
            var retorno = forca.VerificarLetraInformadaJaExiste(letraDigitadaPeloUsuario);

            Assert.IsTrue(retorno);
        }

        [Test]
        public void letra_informada_nao_existe()
        {
            var forca = new ForcaController("CARRO");
            const char letraDigitadaPeloUsuario = 'B';
            forca.ValidarSeLetraContemNaPalavra(letraDigitadaPeloUsuario);
            var retorno = forca.VerificarLetraInformadaJaExiste(letraDigitadaPeloUsuario);

            Assert.IsFalse(retorno);
        }

        [Test]
        public void verificar_e_validar_letras_repetidas_na_mesma_palavra()
        {
            var forca = new ForcaController("ASSERT");
            const char letraDigitadaPeloUsuario = 'S';
            var posicao = forca.AtribuirPosicaoDasLetrasNaPalavra(letraDigitadaPeloUsuario);

            Assert.AreEqual(posicao[1], 'S');
            Assert.AreEqual(posicao[2], 'S');
        }

        [Test]
        public void verificar_posicao_da_letra_no_array()
        {
            var forca = new ForcaController("ASSERT");
            const char letraDigitadaPeloUsuario = 'T';
            var posicao = forca.AtribuirPosicaoDasLetrasNaPalavra(letraDigitadaPeloUsuario);

            Assert.AreEqual(posicao[5], 'T');
        }

        [Test]
        public void letras_maiusculas()
        {
            var forca = new ForcaController("ASSERT");
            const char letraDigitadaPeloUsuario = 'T';
            var letraTratada = forca.TratarMaiusculaMinuscula(letraDigitadaPeloUsuario);

            Assert.AreEqual(letraTratada, 'T');
        }

        [Test]
        public void letras_minusculas()
        {
            var forca = new ForcaController("ASSERt");
            const char letraDigitadaPeloUsuario = 't';
            var letraTratada = forca.TratarMaiusculaMinuscula(letraDigitadaPeloUsuario);

            Assert.AreEqual(letraTratada, 'T');
        }

        [Test]
        public void validacao_do_jogo_finalizado()
        {
            var palavraResposta = "EDCBA";
            var letraInformadaPeloUsuario = 'e';
            var forca = new ForcaController(palavraResposta);
            for (var i = 0; i < palavraResposta.Length; i++)
            {
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);
                letraInformadaPeloUsuario = (char)((int) letraInformadaPeloUsuario - 1);
            }
            var finalizou = forca.FinalizouJogo();

            Assert.IsTrue(finalizou);
        }

        [Test]
        public void validacao_do_jogo_finalizado_2()
        {
            var palavraResposta = "TESTE";
            var forca = new ForcaController(palavraResposta);

            var letraInformadaPeloUsuario = 't';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario)) 
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'e';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario)) 
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 's';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario)) 
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 't';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario)) 
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'e';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario)) 
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            var finalizou = forca.FinalizouJogo();

            Assert.IsTrue(finalizou);
        }

        [Test]
        public void validacao_do_jogo_nao_finalizado()
        {
            var palavraResposta = "TESTE";
            var forca = new ForcaController(palavraResposta);

            var letraInformadaPeloUsuario = 'a';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'b';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'c';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 't';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'e';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            var finalizou = forca.FinalizouJogo();

            Assert.IsFalse(finalizou);
        }

        [Test]
        public void validacao_do_jogo_nao_finalizado_2()
        {
            var palavraResposta = "ABACATE";
            var forca = new ForcaController(palavraResposta);

            var letraInformadaPeloUsuario = 'a';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'b';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'c';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 't';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'x';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            var finalizou = forca.FinalizouJogo();

            Assert.IsFalse(finalizou);
        }
    }
}