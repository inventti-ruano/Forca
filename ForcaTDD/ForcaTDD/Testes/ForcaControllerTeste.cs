using NUnit.Framework;

namespace ForcaTDD.Testes
{
    class ForcaControllerTeste
    {
        [Test]
        [Ignore]
        public void intancia_jogo_da_forca()
        {
            var forca = new ForcaController();
        }

        [Test]
        [Ignore]
        public void usuario_escolhe_uma_letra_e_erra()
        {
            var forca = new ForcaController("CARRO");

            const char letraInvalida = 'X';
            bool acertou = forca.ValidarSeLetraContemNaPalavra(letraInvalida);

            Assert.IsFalse(acertou);
        }

        [Test]
        [Ignore]
        public void usuario_escolhe_uma_letra_e_acerta()
        {
            var forca = new ForcaController("CARRO");

            const char letraValida = 'C';
            bool acertou = forca.ValidarSeLetraContemNaPalavra(letraValida);

            Assert.IsTrue(acertou);
        }

        [Test]
        [Ignore]
        public void letra_informada_jah_existe()
        {
            var forca = new ForcaController("CARRO");
            const char letraDigitadaPeloUsuario = 'C';
            forca.ValidarSeLetraContemNaPalavra(letraDigitadaPeloUsuario);
            var retorno = forca.VerificarLetraInformadaJaExiste(letraDigitadaPeloUsuario);

            Assert.IsTrue(retorno);
        }

        [Test]
        [Ignore]
        public void letra_informada_nao_existe()
        {
            var forca = new ForcaController("CARRO");
            const char letraDigitadaPeloUsuario = 'B';
            forca.ValidarSeLetraContemNaPalavra(letraDigitadaPeloUsuario);
            var retorno = forca.VerificarLetraInformadaJaExiste(letraDigitadaPeloUsuario);

            Assert.IsFalse(retorno);
        }

        [Test]
        [Ignore]
        public void verificar_e_validar_letras_repetidas_na_mesma_palavra()
        {
            var forca = new ForcaController("ASSERT");
            const char letraDigitadaPeloUsuario = 'S';
            var posicao = forca.AtribuirPosicaoDasLetrasNaPalavra(letraDigitadaPeloUsuario);

            Assert.AreEqual(posicao[1], 'S');
            Assert.AreEqual(posicao[2], 'S');
        }

        [Test]
        [Ignore]
        public void verificar_posicao_da_letra_no_array()
        {
            var forca = new ForcaController("ASSERT");
            const char letraDigitadaPeloUsuario = 'T';
            var posicao = forca.AtribuirPosicaoDasLetrasNaPalavra(letraDigitadaPeloUsuario);

            Assert.AreEqual(posicao[5], 'T');
        }

        [Test]
        [Ignore]
        public void letras_maiusculas()
        {
            var forca = new ForcaController("ASSERT");
            const char letraDigitadaPeloUsuario = 'T';
            var letraTratada = forca.TratarMaiusculaMinuscula(letraDigitadaPeloUsuario);

            Assert.AreEqual(letraTratada, 'T');
        }

        [Test]
        [Ignore]
        public void letras_minusculas()
        {
            var forca = new ForcaController("ASSERt");
            const char letraDigitadaPeloUsuario = 't';
            var letraTratada = forca.TratarMaiusculaMinuscula(letraDigitadaPeloUsuario);

            Assert.AreEqual(letraTratada, 'T');
        }

        [Test]
        [Ignore]
        public void validacao_do_jogo_finalizado()
        {
            var palavraResposta = "EDCBA";
            var letraInformadaPeloUsuario = 'e';
            var forca = new ForcaController(palavraResposta);
            for (var i = 0; i < palavraResposta.Length; i++)
            {
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);
                letraInformadaPeloUsuario = (char)((int)letraInformadaPeloUsuario - 1);
            }
            var finalizou = forca.FinalizouJogo();

            Assert.IsTrue(finalizou);
        }

        [Test]
        [Ignore]
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
        [Ignore]
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
        [Ignore]
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

        [Test]
        public void retornar_o_desenho_da_forca_jogo_do_inicio()
        {
            var forca = new ForcaController();

            var desenhoForca = forca.RetornarDesenhoForca();

            Assert.IsTrue(desenhoForca.Contains("_"));
        }

        [Test]
        public void retornar_o_desenho_da_forca_jogo_do_meio()
        {
            var forca = new ForcaController("ABC");
            var letraInformadaPeloUsuario = 'A';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'C';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            var desenhoForca = forca.RetornarDesenhoForca();

            Assert.IsTrue(desenhoForca.Contains("_"));
        }

        [Test]
        public void retornar_o_desenho_da_forca_jogo_do_fim()
        {
            var forca = new ForcaController("ABC");
            var letraInformadaPeloUsuario = 'A';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'B';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'C';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            var desenhoForca = forca.RetornarDesenhoForca();

            Assert.IsFalse(desenhoForca.Contains("_"));
        }

        [Test]
        public void verificar_se_ganhou()
        {
            var forca = new ForcaController("ABC");
            char letraInformadaPeloUsuario = 'a';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'b';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'c';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            var ganhou = forca.RetornarVitoria();
            Assert.IsTrue(ganhou);
        }

        [Test]
        public void verificar_se_ganhou_2()
        {
            var forca = new ForcaController("TESTE");
            char letraInformadaPeloUsuario = 't';
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

            var ganhou = forca.RetornarVitoria();
            Assert.IsTrue(ganhou);
        }

        [Test]
        public void verificar_se_perdeu()
        {
            var forca = new ForcaController("ABC");
            char letraInformadaPeloUsuario = 'x';

            for (int i = 0; i < 6; i++)
            {
                if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                    forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);    
            }

            var perdeu = forca.RetornarVitoria();
            Assert.IsFalse(perdeu);
        }

        [Test]
        public void verificar_se_perdeu_2()
        {
            var forca = new ForcaController("TESTE");
            char letraInformadaPeloUsuario = 't';

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

            letraInformadaPeloUsuario = 'x';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'x';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'x';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'x';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            letraInformadaPeloUsuario = 'x';
            if (!forca.VerificarLetraInformadaJaExiste(letraInformadaPeloUsuario))
                forca.ValidarSeLetraContemNaPalavra(letraInformadaPeloUsuario);

            var perdeu = forca.RetornarVitoria();
            Assert.IsFalse(perdeu);
        }
    }
}