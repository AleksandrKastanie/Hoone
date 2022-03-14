using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoone
{
    public class EraMaja : Hoone
    {
        public int Aken {get; set;}
        public Katus katus;
        public EraMaja(int pindala = 200) : base(pindala)
        {
        }
        public static string Suurus(int alt)
        {
            string home = "";
            if (alt < 51)
            {
                home = " Teile on Väike maja";
            }
            else if (50 < alt && alt < 76)
            {
                home =" Teile on Keskmine maja";
            }
            else if (75 < alt && alt < 101)
            {
                home = " Teile on Suur maja";
            }
            else if (100 < alt && alt < 170)
            {
                home = " Teile on Liiga suur maja";
            }
            else
            {
                home= " Maja krundi jaoks liiga suur";
            }
            return home;
           
        }
    }
}
