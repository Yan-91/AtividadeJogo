using System;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
           //instancia com método construtor sem arg
           Jogo game1 = new Jogo();


            // intancia com método construtor de 1 arg
           Jogo game2 = new Jogo("Call of Duty: Modern Warfare");
           System.Console.WriteLine(game2.nome);


            // instancia com método construtor de 4 arg
           Jogo game3 = new Jogo("Need For Speed: PayBack", 250,"Lançamento",100);
           System.Console.WriteLine(game3.nome);
           System.Console.WriteLine(game3.preco);
           System.Console.WriteLine(game3.descricao);
           System.Console.WriteLine(game3.estoque);
        }
    }
}
