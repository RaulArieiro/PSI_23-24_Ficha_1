using System;

namespace BolasColoridas
{
    class Program
    {
        static void Main(string[] args)
        {

            Cor cor1 = new Cor(200, 0, 255);
            Cor cor2 = new Cor(147, 55, 0);
            Cor cor3 = new Cor(0, 255, 0);

            Bola bola1 = new Bola(cor1,21);
            Bola bola2 = new Bola(cor2,50);
            Bola bola3 = new Bola(cor3, 230);

            Cor b1Cor = bola1.GetCor();
            Cor b2Cor = bola2.GetCor();
            Cor b3Cor = bola3.GetCor();

            bola1.Atirar();
            bola2.Atirar();
            bola3.Atirar();
            bola2.Atirar();
            bola1.Atirar();
            bola1.Atirar();

            bola3.Pop();
            bola1.Pop();
            
            Console.WriteLine("Bola 1");
            Console.WriteLine("- Cor");
            Console.WriteLine($"-- R: {b1Cor.GetterRe()}");
            Console.WriteLine($"-- G: {b1Cor.GetterGr()}");
            Console.WriteLine($"-- B: {b1Cor.GetterBl()}");
            Console.WriteLine($"- Vezes atirada: {bola1.GetVezesAtirada()}");
            Console.WriteLine();

            Console.WriteLine("Bola 2");
            Console.WriteLine("- Cor");
            Console.WriteLine($"-- R: {b1Cor.GetterRe()}");
            Console.WriteLine($"-- G: {b1Cor.GetterGr()}");
            Console.WriteLine($"-- B: {b1Cor.GetterBl()}");
            Console.WriteLine($"- Vezes atirada: {bola2.GetVezesAtirada()}");
            Console.WriteLine();


            Console.WriteLine("Bola 3");
            Console.WriteLine("- Cor");
            Console.WriteLine($"-- R: {b1Cor.GetterRe()}");
            Console.WriteLine($"-- G: {b1Cor.GetterGr()}");
            Console.WriteLine($"-- B: {b1Cor.GetterBl()}");
            Console.WriteLine($"- Vezes atirada: {bola3.GetVezesAtirada()}");
            Console.WriteLine();


        }
        
    }
}
