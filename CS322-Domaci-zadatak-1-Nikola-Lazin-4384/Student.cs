using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Domaci_zadatak_1_Nikola_Lazin_4384
{
    public class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Pol { get; set; }

        public Student() { }

        public Student(string ime, string prezime, string adresa, string pol) {
            this.Ime = ime;
            this.Prezime= prezime;
            this.Adresa = adresa;
            this.Pol = pol;
        }



    }
}
