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
    public class PredmetController : ApiController
    {
          private readonly IPredmetRepository _ipredmetrepository;
           public PredmetController (PredmetRepository PredmetRepository)
          {
              this._ipredmetrepository = PredmetRepository;
           }
        [HttpGet]
        [Route("api/predmet")]
        public List<predmetModel> Get()
        {
            return this._ipredmetrepository.Get();
        }
        [HttpGet]
        [Route("api/predmet/{id}")]
        [ResponseType(typeof(predmet))]
        public IHttpActionResult Getpredmet([FromUri] int id)
        {
            predmet predmet = this._ipredmetrepository.Getpredmet(id);
            if (predmet == null)
            {
                return NotFound();
            }

            return Ok(predmet);
        }
        [HttpPost]
        [Route("api/predmet")]
        [ResponseType(typeof(predmet))]
        public IHttpActionResult Poststudent([FromBody] predmet predmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            this._ipredmetrepository.Postpredmet(predmet);
            return Ok();
        }
        [HttpPut]
        [Route("api/predmet/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Putpredmet([FromUri] int id, [FromBody] predmet predmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != predmet.id)
            {
                return BadRequest();
            }
            this._ipredmetrepository.Putpredmet(predmet);
            return Ok();
        }
        [HttpDelete]
        [Route("api/predmet/{id}")]
          [ResponseType(typeof(predmet))]
        public IHttpActionResult Deletestudent(int id)
        {
            predmet predmet = this._ipredmetrepository.Getpredmet(id);
            if (predmet == null)
            {
                return NotFound();
            }
            this._ipredmetrepository.Deletepredmet(id);
            return Ok();
        }
    }
}
