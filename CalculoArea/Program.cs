using System;

namespace CalculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char escolha;
            
            Console.ForegroundColor= ConsoleColor.Black;
            Console.BackgroundColor= ConsoleColor.Blue;
            Console.WriteLine("#################################################");
            Console.WriteLine("###################   MENU   ####################");
            Console.WriteLine("#################################################");
            Console.WriteLine("##  [T] TRIANGULO  [Q] QUADRILATERO  [C] CUBO  ##");
            Console.WriteLine("#################################################");
            Console.ResetColor();

            escolha = char.Parse(Console.ReadLine().ToUpper());

            if (escolha == 'T')
            {
                Console.WriteLine("Informe a base do Triangulo: ");
                float baseTriangulo = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura do Triangulo: ");
                float alturaTriangulo = float.Parse(Console.ReadLine());

                float triangulo = (baseTriangulo * alturaTriangulo) / 2;

                Console.WriteLine("A área do Triangulo é: " + triangulo);
            }
            else if (escolha == 'Q')
            {
                Console.WriteLine("Informe o lado do Quadrilatero");
                float ladoQuadrado = float.Parse(Console.ReadLine());

                float quadrado = ladoQuadrado * ladoQuadrado;

                Console.WriteLine("A área do Quadrilátero é: " + quadrado);
            }
            else if (escolha == 'C')
            {
                Console.WriteLine("Informe a aresta do Cubo: ");
                float arestaCubo = float.Parse(Console.ReadLine());

                float cubo = (arestaCubo * arestaCubo) * 6;

                Console.WriteLine("A área do Cubo e: " + cubo);
            }
            else
            {
                Console.BackgroundColor= ConsoleColor.Red;
                Console.WriteLine("OPÇÃO ÍNVALIDA");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
