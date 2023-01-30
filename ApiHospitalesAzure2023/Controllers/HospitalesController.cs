using ApiHospitalesAzure2023.Models;
using ApiHospitalesAzure2023.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHospitalesAzure2023.Controllers
{
    //https://servicioapo.com/api/hospitales
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalesController : ControllerBase
    {
        private RepositoryHospital repo;
        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        //https://servicioapo.com/api/hospitales
        [HttpGet]
        public ActionResult<List<Hospital>> GetHospitales()
        {
            return this.repo.GetHospitales();
        }

        //https://servicioapo.com/api/hospitales
        [HttpGet("{id}")]
        public ActionResult<Hospital> FindHospital(int id)
        {
            return this.repo.FindHospital(id);
        }
    }
}
