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
            Console.WriteLine("Introduceti un numar");
            string line = Console.ReadLine();
            int numar;
            numar= int.Parse(line);

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
            while(numar>0)
            {
                cat = numar / baza;
                rest = numar % baza;
                stiva.Push(rest);
                // sau in loc de stiva folosim doar Console.Write(rest); pentru partea aceasta
                numar = numar / baza;
                
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
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
