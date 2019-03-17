using System;

namespace Aula3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de objetos para o calculo da função de números complexos
            ComplexNumber N1 = new ComplexNumber(2.8, 4);
            ComplexNumber N2 = new ComplexNumber(4, 7.7);

            ComplexNumber N3 = N1.addition(N2);
            ComplexNumber N4 = N1.addition(N2).subtraction(N3);

            //Mostra o resultado final na tela
            Console.WriteLine($"{ N4.RealPart.ToString()} + { N4.ImaginaryPart.ToString()} i");

            //Para impedir que o programa finalize de forma imediata
            Console.ReadKey();

        }
    }
}
