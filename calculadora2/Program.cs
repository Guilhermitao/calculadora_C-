using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            int operacao;
            double numero1, numero2;
            double resultado1;
            do
            {
                Console.WriteLine("digite um numero");
                numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("digite outro numero");
                numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine("escolha uma operacao [1=soma, 2=subtracao, 3=multiplicacao, 4=divisao]");
                operacao = int.Parse(Console.ReadLine());
                switch (operacao)
                {
                    case 1:
                        resultado1 = (numero1 + numero2);
                        Console.WriteLine("o resultado da soma e");
                        Console.WriteLine(resultado1);
                        break;
                    case 2:
                        resultado1 = (numero1 - numero2);
                        Console.WriteLine("o resultado da subtracao e");
                        Console.WriteLine(resultado1);
                        break;
                    case 3:
                        resultado1 = (numero1 * numero2);
                        Console.WriteLine("o resultado da multiplicacao e");
                        Console.WriteLine(resultado1);
                        break;
                    case 4:
                        resultado1 = (numero1 / numero2);
                        Console.WriteLine("o resultado da divisao e");
                        Console.WriteLine(resultado1);
                        break;
                }
                Console.WriteLine("deseja fazer outra conta?aperte qualquer tecla para continuar[s=parar programa] ");
                continuar = Console.ReadLine();
            } while (continuar != "s" & continuar != "S");
        }
    }
}
