using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Students.GetAll
{
    public class ServicesGetAll : IServicesGetAll
    {
        public object GetAll()
        {
            return new { name = "string" }; //retorna un objeto anonimo
        }
    }
}
