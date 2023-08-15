using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo da adivinha!");
            Console.WriteLine("Ao longo do jogo terás novas dicas.");
            Console.WriteLine("");
            Console.WriteLine("Qual é o animal que, tem 4 patas e é independente ?");

            string secretword = "gato";
            string guess = Console.ReadLine();
            int tries = 0;
            int limit = 5;
            bool playing = false;
            int result = 5;

            Game(secretword, guess, tries, limit, playing, result);

            Console.ReadLine();

        }

        static void Game(string secretword, string guess, int tries, int limit, bool playing, int result)
        {
            while (guess != secretword && !playing)
            {
                if (tries < limit)
                {
                    Console.WriteLine("Errado, tenta novamente!");
                    Console.WriteLine("Ainda tens " + result + " tentativas");
                    guess = Console.ReadLine();
                    tries++;
                    result--;
                }
                else
                {
                    playing = true;
                }
            }
                if (playing)
                {
                    Console.WriteLine("Perdeste!!");
                }
                else
                {
                    Console.WriteLine("Ganhaste!!");
                }
        }

    }
}
