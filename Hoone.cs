using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoone
{
    public class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;
        public int Puud { get; set; }
        public int Tara { get; set; }

        public Hoone(int pindala = 200)
        {
            Pindala = pindala;
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
        }


        public Uks GetUks()
        {
            return uks;
        }
        
    }
}
