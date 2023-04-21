using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main()
        {
            char[] hexDigitos = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 
                                 'A', 'B', 'C', 'D', 'E', 'F'};

            int numero = PedirNumero();

            Console.WriteLine($"{numero} en hexadecimal: #{DecToHex(numero, hexDigitos)}");
            Console.ReadKey();
        }

        static int PedirNumero()
        {
            int numero = 0;

            do
            {
                Console.Write("Ingrese un número decimal: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Error: número inválido.");
                }

            } while (numero < 0);

            return numero;
        }

        static string DecToHex(int cociente, char[] hexDigitos)
        {
            int resto = cociente % 16;

            if (cociente < 16)
            {
                return hexDigitos[cociente].ToString();
            }
            else
            {
                return DecToHex(cociente / 16, hexDigitos) + hexDigitos[resto];
            }
        }
    }
}
