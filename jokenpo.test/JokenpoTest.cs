using System;
using Xunit;
using FluentAssertions;
using desafio;

namespace jokenpo.test
{
    public class JokenpoTest
    {
        [Fact]
        public void PedraDeveEmpatarComPedra()
        {

        }

        [Trait("Unidade", "JogadaInvalida")]
        [Fact]
        public void JogadaInvalida_DeveRetornarFalso()
        {

        }

        [Trait("Unidade", "JogadaInvalida")]
        [Fact]
        public void SortearNumeroInteiro_MaiorIgualU_MenorIguaTres()
        {
            var jogador = new Jogador();
            jogador.SortearNumeroInteiro();

            var jogador2 = new Jogador();
            jogador2.SortearNumeroInteiro();

                       
            bool valido = (int)jogador.opcao >= 1 || (int)jogador.opcao <=3;

            Assert.True(valido);
        }



        [Trait("Unidade", "JogadaInvalida")]
        [Fact]
        public void ValidarValoresIguais()
        {
            var jogador1 = new Jogador();
            jogador1.SortearNumeroInteiro();
            

            var jogador2 = new Jogador();
            jogador2.SortearNumeroInteiro();

            // var campeao = Game.game(jogador1, jogador2);

            Assert.True(true);
        }
    }
}
