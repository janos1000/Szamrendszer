using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{
    internal class Program
    {
        static void Main(string[] args) { 
        
                Console.Write("Kérem, adjon meg egy tizedes számot: ");
                int decimalNumber = int.Parse(Console.ReadLine());
                string binaryNumber = ToBinary(decimalNumber);
                Console.WriteLine($"A szám kettes számrendszerbeli megfelelője: {binaryNumber}");
            }

            static string ToBinary(int n)
            {
                if (n == 0)
                    return "0";

                string binary = "";
                while (n > 0)
                {
                    binary = (n % 2) + binary;
                    n /= 2;
                }
                return binary;
            }
        }
    }