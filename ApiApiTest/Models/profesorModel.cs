using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiApiTest.Models
{
    public class profesorModel
    {
        public string Ime { get; set; }
        public string Srednje_ime { get; set; }
        public string Prezime { get; set; }
        public Nullable<System.DateTime> datum_rodjenja { get; set; }
        public Nullable<System.DateTime> datum_postavljanja { get; set; }
        public string naziv_predmeta { get; set; }
        public int id { get; set; }
    }
}