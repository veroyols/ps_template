using Application.Interfaces;
using Application.UseCase.Students.GetAll; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IServicesGetAll _services;

        public StudentsController(IServicesGetAll services)
        {
            _services = services;
        }

            [HttpGet]
        public IActionResult GetAll()
        {
            //var services = new ServicesGetAll(); no creo el objeto porque se inyecto
            var result = _services.GetAll();
             return new JsonResult(result);
           //return new JsonResult(new { anonimo = "objetoAnonimo"});

        }
    }
}
