using ApiApiTest.Models;
using ApiApiTest.Repository;
using ApiApiTest.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ApiApiTest.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentRepository _istudentrepository;
        public StudentController(IStudentRepository StudentRepository)
        {
            this._istudentrepository = StudentRepository;
        }
        [HttpGet]
        [Route("api/student")]
        public IHttpActionResult Get()
        {
            return Ok(this._istudentrepository.Get());

        }
        [HttpGet]
        [Route("api/studentSlusa")]
        public IHttpActionResult GetStudentsFromClass([FromUri] string Naziv_predmeta)
        {
            return Ok(this._istudentrepository.GetStudentsFromClass(Naziv_predmeta));

        }
        [HttpGet]
        [Route("api/student/{id}")]
       // [ResponseType(typeof(student))]
        public IHttpActionResult Getstudent([FromUri] int id)
        {
            
            studentModel studentModell = this._istudentrepository.Getstudent(id);
            if (studentModell == null)
            {
                return NotFound();
            }
            else
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
                return Ok(student);
            }
        }
        [HttpPost]
        [Route("api/students")]
        [ResponseType(typeof(student))]
        public IHttpActionResult Poststudent([FromBody] student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            studentModel studentModell = new studentModel();
            studentModell.id = student.id;
            studentModell.ime = student.ime;
            studentModell.br_indexa = student.br_indexa;
            studentModell.datum_rodjenja = student.datum_rodjenja;
            studentModell.jmbg = student.jmbg;
            studentModell.prezime = student.prezime;
            studentModell.srednje_ime = student.srednje_ime;
            studentModell.studentcol = student.studentcol;
            this._istudentrepository.Poststudent(studentModell);
            return Ok();
        }
        [HttpPut]
        [Route("api/student/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Putstudent([FromUri] int id, [FromBody] student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.id)
            {
                return BadRequest();
            }
            studentModel studentModell = new studentModel();
            studentModell.id = student.id;
            studentModell.ime = student.ime;
            studentModell.br_indexa = student.br_indexa;
            studentModell.datum_rodjenja = student.datum_rodjenja;
            studentModell.jmbg = student.jmbg;
            studentModell.prezime = student.prezime;
            studentModell.srednje_ime = student.srednje_ime;
            studentModell.studentcol = student.studentcol;
            this._istudentrepository.Putstudent(studentModell);
            return Ok();
        }
        [HttpDelete]
        [Route("api/student/{id}")]
      //  [ResponseType(typeof(student))]
        public IHttpActionResult Deletestudent(int id)
        {
            studentModel studentModell = this._istudentrepository.Getstudent(id);
            if (studentModell == null)
            {
                return NotFound();
            }
           
           
                this._istudentrepository.Deletestudent(id);
                return Ok();
           
        }
    }
}
