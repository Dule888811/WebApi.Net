﻿using ApiApiTest.Models;
using ApiApiTest.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace ApiApiTest.Repository
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public  StudentRepository(skolaEntities context) : base(context)
       {

       }
        public List<studentModel> Get()
        {
            var profesori = context.student.ToList();

            List<studentModel> ListaStudenata = new List<studentModel>();
            foreach (var profa in profesori)
            {
                studentModel model = new studentModel();

                model.id = profa.id;
                model.ime = profa.ime;
                model.srednje_ime = profa.srednje_ime;
                model.datum_rodjenja = profa.datum_rodjenja;
                model.br_indexa = profa.br_indexa;
                model.jmbg = profa.jmbg;
                model.prezime = profa.prezime;
                model.studentcol = profa.studentcol;
                ListaStudenata.Add(model);
            }
            return ListaStudenata;
        }

        public List<student> GetStudentsFromClass(string Naziv_predmeta)
        {
            List<student> ListaStudenata = new List<student>();
            student student = new student();
            var students = this.context.student.ToList();
            //  studentModel studentSlusaModell = new studentModel();
            var br_indexa = from f in this.context.slusa
                                         where f.naziv_predmeta == Naziv_predmeta
                                         select f.br_indexa;
            foreach(var br in br_indexa.ToList())
            {
                foreach(var s in students)
                {
                    if (s.br_indexa == br)
                    {
                        ListaStudenata.Add(s);
                    }
                }
               
            }
            return ListaStudenata;
        }


        public studentModel Getstudent(int id)
        {
            studentModel studentModell = new studentModel();
           student student = context.student.Find(id);
            if (student == null)
            {
                return null;
            }
            else
            {
                studentModell.br_indexa = student.br_indexa;
                studentModell.datum_rodjenja = student.datum_rodjenja;
                studentModell.id = student.id;
                studentModell.ime = student.ime;
                studentModell.prezime = student.prezime;
                studentModell.jmbg = student.jmbg;
                studentModell.srednje_ime = student.srednje_ime;
                studentModell.studentcol = student.studentcol;
                return studentModell;
            }
        }
        public void Putstudent(studentModel studentModell)
        {
            student student = new student();
            student.id = studentModell.id;
            student.ime = studentModell.ime;
            student.br_indexa = studentModell.br_indexa;
            student.datum_rodjenja = studentModell.datum_rodjenja;
            student.jmbg = studentModell.jmbg;
            student.prezime = studentModell.prezime;
            student.srednje_ime = studentModell.srednje_ime;
            student.studentcol = studentModell.studentcol;
            context.Entry(student).State = EntityState.Modified;
            base.SaveChanges();
        }
        public void Poststudent(studentModel studentModell)
        {
            student student = new student();
            student.id = studentModell.id;
            student.ime = studentModell.ime;
            student.br_indexa = studentModell.br_indexa;
            student.datum_rodjenja = studentModell.datum_rodjenja;
            student.jmbg = studentModell.jmbg;
            student.prezime = studentModell.prezime;
            student.srednje_ime = studentModell.srednje_ime;
            student.studentcol = studentModell.studentcol;
            context.student.Add(student);
            base.SaveChanges();

        }
        public void Deletestudent(int id)
        {
            
            student student = context.student.Find(id);
            context.student.Remove(student);
            base.SaveChanges();

        }

        public void Dispose()
        {
            context.Dispose();
        }


    }
}