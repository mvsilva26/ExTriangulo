using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 lados para um triângulo");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if( (a == b) && (b == c) )
            {
                Console.WriteLine("Triângulo Equilátero");
            }else if( (a != b) && (b != c) && (a != c))
            {
                Console.WriteLine("Triângulo Escaleno");
            }
            else
            {
                Console.WriteLine("Triâgulo Isosceles");
            }
            Console.ReadLine();
        }
    }
}
