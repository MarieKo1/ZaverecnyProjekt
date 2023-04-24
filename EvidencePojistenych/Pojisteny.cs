using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    internal class Pojisteny
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string TelefonniCislo { get; set; }
        public int Vek { get; set; }

        public override string ToString()
        {
            string retezec = Jmeno + " " + Prijmeni + " " + Vek + " " + TelefonniCislo;
            return retezec;
        }
    }
}
