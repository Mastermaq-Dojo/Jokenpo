using System;
public class Jogador
{
    public string playername { get; set; }
    public Opcoes opcao { get; set; }
    public Jogador()
    {

    }
    public Jogador(string name)
    {
        this.playername = name;
    }

    public void SortearNumeroInteiro()
    {
        int numerosorteado = (int)(DateTime.Now.Ticks % 2) + 1;

        this.opcao = (Opcoes)numerosorteado;
    }

    public bool VerificarNumerosIguais(int num, int num2)
    {

    }

    public int GeraNumerosRandom()
    {
        int num = 0;
        Random rnd = new Random();

        for (int i = 1; i <= 1; i++)
           num =  rnd.Next(1, 4);

           return num;
    }


    public enum Opcoes
    {
        Pedra,
        Papel,
        Tesoura
    }
}