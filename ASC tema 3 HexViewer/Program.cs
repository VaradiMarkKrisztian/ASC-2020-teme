using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ASC_tema_3_HexViewer
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("introduceti calea fisierului");
            string path = Console.ReadLine();
            FileStream file = new FileStream(path, FileMode.Open);
            bool stop = true;
            while (stop)
            {
                    int nrocteti = 16;
                    int coloana1 = 0;
                    byte[] liniedebiti = new byte[nrocteti];
                    while (file.Read(liniedebiti, 0, nrocteti) > 0)
                    {
                        string coloana2 = BitConverter.ToString(liniedebiti);
                            //Convert.ToBase64String(liniedebiti, (Base64FormattingOptions)16); daca coloana2 era de tip int //?
                                     //ToInt32 -||-
                        string text = "";
                        for (int i = 0; i < liniedebiti.Length; i++)
                        {
                            text += liniedebiti[i] < ' ' ? "=" : ((char)liniedebiti[i]).ToString();
                        }
                        Console.WriteLine($"{coloana1++:X7}0: {coloana2} | {text}"); 
                        
                        stop = false;
                        
                    }
               
            }
            file.Close();
            Console.ReadKey();
        }
    }
}
