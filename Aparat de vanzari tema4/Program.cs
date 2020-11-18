using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aparat_de_vanzari_tema4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            metodarapida();
            
            /*     int suma = 0;
                 int n = int.Parse(Console.ReadLine());
                 while (suma < 20)
                 {

                     //A -> B -> C else A-> C -> D
                     if (n == 5) suma = suma + n;
                     else if (n == 10) suma = suma + n;
                     n = int.Parse(Console.ReadLine());
                     if(n==5) suma = suma + n;
                     else if(n==10)
                     n = int.Parse(Console.ReadLine());

                 }
         */
        }
            private static void metodarapida()
            {
                int redo = 1;
                while (redo != 2)
                {
                Console.WriteLine("introduceti 5, 10 sau 15 monede in aparat");
                int suma = 0;
                    while (suma <= 20)
                    {
                        int n = int.Parse(Console.ReadLine());
                        if (n == 5 || n == 10 || n == 15)
                            suma = suma + n;
                    if (suma >= 20) break;
                    }

                if (suma == 20) Console.WriteLine($"Produsul a fost eliberat");
                else if (suma > 20)
                {
                    suma = suma - 20;
                    if (suma == 5) Console.WriteLine("Produsul a fost eliberat si restul dumneavoastra este 1 nickel");
                    if (suma == 10) Console.WriteLine("Produsul a fost eliberat si restul dumneavoastra este 1 dime");
                }
                        Console.WriteLine("Daca doriti sa mai cumparati un produs apasati tasta 1");
                        Console.WriteLine("Sau daca doriti sa plecati apasati tasta 2");
                        redo = int.Parse(Console.ReadLine());
                }
            }
        }
    }

