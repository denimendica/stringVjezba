using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sVelika, sMala, sPrvaTri, sZadnjihPet, s8_11;


            Console.Write("Unesite niz znakova: ");
            string nizZnakova = Console.ReadLine();

            Console.WriteLine(nizZnakova.ToUpper());
            Console.WriteLine(nizZnakova.ToLower());
            Console.WriteLine(nizZnakova.Substring(0, 3));
            Console.WriteLine(nizZnakova.Substring(7, 4));

            Console.ReadKey();
        }
    }
}
