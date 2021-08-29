using System;

namespace Joguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array opcoes = ["Pedra", "Papel", "Tesoura"];
            string jogador1 = "";
            string jogador2 = "";
            int fim = 0;

            while (fim == 0)
            {
                Console.WriteLine("Escolha Pedra, Papel ou Tesoura");
                jogador1 = Console.ReadLine();
                Console.WriteLine("Escolha Pedra, Papel ou Tesoura");
                jogador2 = Console.ReadLine();

                if ((jogador1 == "Papel" && jogador2 == "Pedra") ||
                    (jogador1 == "Pedra" && jogador2 == "Tesoura") ||
                    (jogador1 == "Tesoura" && jogador2 == "Papel"))
                {
                    fim = 1;
                }
                else if ((jogador2 == "Papel" && jogador1 == "Pedra") ||
                  (jogador2 == "Pedra" && jogador1 == "Tesoura") ||
                  (jogador2 == "Tesoura" && jogador1 == "Papel"))
                {
                    fim = 2;
                }
                else
                {
                    fim = 0;
                }
            }
            if (fim == 1)
            {
                Console.WriteLine("Jogador 1 ganhou");
            }
            else
            {
                Console.WriteLine("Jogador 2 ganhou");
            }


        }
    }
}
