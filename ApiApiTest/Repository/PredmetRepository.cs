using ApiApiTest.Models;
using ApiApiTest.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiApiTest.Repository
{
    public class PredmetRepository : BaseRepository,IPredmetRepository
    {
        public PredmetRepository(skolaEntities context) : base(context)
        {

        }
        public List<predmetModel> Get()
        {
            var profesori = context.predmet.ToList();

            List<predmetModel> ListaPredmeta = new List<predmetModel>();
            foreach (var profa in profesori)
            {
                predmetModel model = new predmetModel();

                model.Naziv_predmeta = profa.Naziv_predmeta;
                model.Sifru_predmeta = profa.Sifru_predmeta;
                model.Kratak_opis = profa.Kratak_opis;
                model.Labaratoriske_vezbe = profa.Labaratoriske_vezbe;
                model.Godina = profa.Godina;
                model.id = profa.id;
                ListaPredmeta.Add(model);
            }
            return ListaPredmeta;
        }
        public predmet Getpredmet(int id)
        {
            return context.predmet.Find(id);
        }
        public void Putpredmet(predmet predmet)
        {
            context.Entry(predmet).State = EntityState.Modified;
            base.SaveChanges();
        }
        public void Postpredmet(predmet predmet)
        {

            context.predmet.Add(predmet);
            base.SaveChanges();

        }
        public void Deletepredmet(int id)
        {

            predmet predmet = this.Getpredmet(id);

            context.predmet.Remove(predmet);
            base.SaveChanges();

        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}