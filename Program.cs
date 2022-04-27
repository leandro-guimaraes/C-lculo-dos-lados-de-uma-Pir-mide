using System;

namespace projetoPiramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

         
            Console.WriteLine("Digite o valor do lado A do triângulo");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado B do trângulo");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado c do trângulo");
            C = int.Parse(Console.ReadLine());

            if ( A == B && B!=C && A!=C ) 

            {
                Console.WriteLine("Este é um triângulo Isósceles, pois tem dois lados iguais e um diferente ");
            }

            else
            {}

            if ( A == B && B == C && A == C )

            {
                Console.WriteLine("Este é um triângulo Equilátero, pois tem os três  lados iguais ");
            }

            else
            { }

            if ( A != B && B != C && A != C)

            {
                Console.WriteLine("Este é um triângulo escaleno, pois tem os três  lados diferentes ");
            }

            else
            { }


        }
    }
}
