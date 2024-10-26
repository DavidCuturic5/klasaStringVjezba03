using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVjezba03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova");
            string unos = Console.ReadLine();

            string sVelika = unos.ToUpper();
            string sMala = unos.ToLower();
            string sPrvaTri = unos.Substring(0, 3);
            string sZadnjihPet = unos.Substring(5);
            string s8_11 = unos.Substring(7,4);

            Console.WriteLine("Velika slova:" + sVelika);
            Console.WriteLine("Mala slova:" +sMala);
            Console.WriteLine("Prva tri slova:" +sPrvaTri);
            Console.WriteLine("Zadnjih pet:" +sZadnjihPet);
            Console.WriteLine("Slova od 8-11:" +s8_11);
            Console.ReadKey(); 
        }
    }
}
