using ApiApiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiApiTest.Repository.IRepository
{
     public  interface IPredmetRepository
    {
        List<predmetModel> Get();
        predmet Getpredmet(int id);
        void Putpredmet(predmet predmet);
        void Postpredmet(predmet predmet);
        void Deletepredmet(int id);
        void Dispose();
    }
}
