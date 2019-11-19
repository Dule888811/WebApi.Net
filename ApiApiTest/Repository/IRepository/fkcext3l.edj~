using ApiApiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiApiTest.Repository.IRepository
{
    public interface IStudentRepository
    {
        List<studentModel> Get();
        List<student> GetStudentsFromClass(string Naziv_predmeta);
        studentModel Getstudent(int id);
        void Putstudent(studentModel studentModell);
        void Poststudent(studentModel studentModell);
        void Deletestudent(int id);
        void Dispose();
    }
}
