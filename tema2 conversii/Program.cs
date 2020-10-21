using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace tema2_conversii
{
    class Program
    {
        static void Main(string[] args)
        {
            //add cod de verificare pentru baza si nr
            Console.WriteLine("Introduceti un numar");
            string line = Console.ReadLine();
            
           uint numar= (uint)int.Parse(line);
            uint semn = numar;

            Console.WriteLine("introduceti o baza de la 2 la 16");
            int baza;
            baza = int.Parse(Console.ReadLine());

            while(baza<2 || baza>16)
            {
                Console.WriteLine("baza nu se afla intre 2 si 16");
                Console.WriteLine("introduceti o alta baza");
                baza = int.Parse(Console.ReadLine());
            }

            int cat=0, rest=0;
            string result = "";
            
            Stack<int> stiva = new Stack<int>();
            while(numar!=0)
            {
                cat = (int)(numar / baza);
                rest = (int)(numar % baza);
                stiva.Push(rest);
                // sau in loc de stiva folosim doar Console.Write(rest); pentru partea aceasta
                numar = (uint)(numar / baza);
                
            }

           
            string[] litere = { "A", "B", "C", "D", "E", "F" };
            while(stiva.Count>0)
            {
                int cifra = stiva.Pop();
                if (cifra>=10)
                {
                    cifra += 55;
                    result = result + (char)cifra;
                }
                else
                {
                    result = result + cifra;
                }
            }

            if (baza == 2)
            {
                if (semn < 0)
                {
                    Console.WriteLine($"(1){result}"); //?
                }
                else if (semn > 0)
                {
                    Console.WriteLine($"(0){result}");
                }
                
            }
            else
            {
                Console.WriteLine(result);
            }
           
            Console.ReadKey();

        }
    }
}
