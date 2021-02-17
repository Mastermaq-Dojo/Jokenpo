public class ValidaJogo
{
    public string Validar(Jogador jogador1, Jogador jogador2)
    {
        if(jogador1.opcao.Equals((Jogador.Opcoes.Pedra)))
        {
            if(jogador2.opcao.Equals(Jogador.Opcoes.Pedra))
            {
                return "Empate";
            }
            if(jogador2.opcao.Equals(Jogador.Opcoes.Tesoura))
            {
               return "Vitória";
            }
            if(jogador2.opcao.Equals(Jogador.Opcoes.Papel))
            {
               return "Derrota";
            }
        }

        if(jogador1.opcao.Equals((Jogador.Opcoes.Papel)))
        {
            if(jogador2.opcao.Equals(Jogador.Opcoes.Tesoura))
            {
                return "Derrota";
            }
            if(jogador2.opcao.Equals(Jogador.Opcoes.Pedra))
            {
                return "Empate";
            }
            if(jogador2.opcao.Equals(Jogador.Opcoes.Pedra))
            {
                return "Empate";
            }
        }

        if(jogador1.opcao.Equals((Jogador.Opcoes.Tesoura)))
        {
            if(jogador2.opcao.Equals(Jogador.Opcoes.Pedra))
            {
                return "Empate";
            }
            if(jogador2.opcao.Equals(Jogador.Opcoes.Pedra))
            {
                return "Empate";
            }
            if(jogador2.opcao.Equals(Jogador.Opcoes.Pedra))
            {
                return "Empate";
            }
        }
    }
}