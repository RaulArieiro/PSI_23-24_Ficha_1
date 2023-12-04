using System;

namespace BolasColoridas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cor Cor1 = new Cor(0,255,0);
            Bola Bola1 = new Bola(Cor1, 300);
            Console.WriteLine($"Cor da bola 1 é ({Cor1.getterBl()}) ");

            Cor Cor2 = new Cor(0,0,255);
            Bola Bola2 = new Bola(Cor2,20);
            Console.WriteLine($"Cor da bola 2 é ({Cor2.getterGr()}) ");

        }
        
    }
}
