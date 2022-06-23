using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraavancada
{
    class Program2
    {
        static void Main(string[] args)
        {
            double numero_1, numero_2;
            int num = 0, tab = 0;
            string continua;
            Console.BackgroundColor = ConsoleColor.DarkBlue;//cor que ficará atras do texto
            Console.ForegroundColor = ConsoleColor.White;//cor do texto
            do
            {
                Console.WriteLine("digite o primeiro numero");
                numero_1 = double.Parse(Console.ReadLine());
                Console.WriteLine("digite o segundo numero");
                numero_2 = double.Parse(Console.ReadLine());
                Console.WriteLine("os numeros digitados sao " + numero_1 + " e " + numero_2);
                Console.WriteLine("Escolha uma operação:\r\n1=Adicão.\r\n2=Subtração.\r\n3=Multiplicação.\r\n4=Divisão.");
                /* \r\n = <br> */
                num = int.Parse(Console.ReadLine());
                //Console.ReadKey();
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Adicão");
                        Console.WriteLine("o resultado da soma é: "
                            + numero_1 + " + " + numero_2 + " = " + (numero_1 + numero_2));
                        break;
                    case 2:
                        Console.WriteLine("Subtração");
                        Console.WriteLine("o resultado da subtração é: "
                            + numero_1 + " - " + numero_2 + " = " + (numero_1 - numero_2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplicação");
                        Console.WriteLine("o resultado da multiplicação é: "
                            + numero_1 + " X " + numero_2 + " = " + (numero_1 * numero_2));
                        break;
                    case 4:
                        Console.WriteLine("Divisão");
                        Console.WriteLine("o resultado da multiplicação é: "
                            + numero_1 + " / " + numero_2 + " = " + (numero_1 / numero_2));
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }//switch
                Console.WriteLine("Quer continuar fazendo conta?");
                Console.WriteLine("s=sim.\r\nQualquer botão = saida");
                continua = Console.ReadLine();
            } while (continua == "S" || continua == "s");// & = e; || = ou;
        }//static void Main(string[] args)
    }//class Program2
}//namespace calculadoraavancada
