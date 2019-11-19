using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiApiTest.Models
{
    public class predmetModel
    {
        public string Naziv_predmeta { get; set; }
        public string Sifru_predmeta { get; set; }
        public string Kratak_opis { get; set; }
        public Nullable<bool> Labaratoriske_vezbe { get; set; }
        public Nullable<sbyte> Godina { get; set; }
        public int id { get; set; }
    }
}