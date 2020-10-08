using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moore_s_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; float an = 0; int avansare = 1; int luna=0;
            Console.WriteLine("introduceti viteza puterii de calcul");
            n = int.Parse(Console.ReadLine());
            while (n >= avansare)
            {
                avansare = avansare * 2;
                luna =luna + 18;
            }
            Console.WriteLine($"viteza puterii de calcul {n} va fi obtinuta in {luna} luni");
            Console.WriteLine($"adica aproximativ in {an = (float)luna / 12} ani");
            Console.ReadKey();
        }
    }
}
