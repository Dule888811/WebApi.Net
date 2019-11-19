using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiApiTest.Models
{
    public class studentModel
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string srednje_ime { get; set; }
        public Nullable<System.DateTime> datum_rodjenja { get; set; }
        public Nullable<int> br_indexa { get; set; }
        public string jmbg { get; set; }
        public string prezime { get; set; }
        public string studentcol { get; set; }
    }
}