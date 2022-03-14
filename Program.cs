using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoone
{
    class Program
    {
        static void Main(string[] args)
        {
            int alt;
            
            Console.Write("Sisestage maja piirkond: ");
            alt = int.Parse(Console.ReadLine());
            EraMaja majake = new EraMaja();
            Console.WriteLine(EraMaja.Suurus(alt));
            Console.Write("Sisestage Teie nimi: ");
            Inimene mees = new Inimene(Console.ReadLine());
            majake.uks = new Uks("must");
            mees.hoone = majake;
            mees.NaitaInfo();

            Console.ReadLine();
        }
    }
}
