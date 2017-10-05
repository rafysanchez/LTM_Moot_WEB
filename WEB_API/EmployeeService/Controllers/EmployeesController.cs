using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    //[Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Produtos> Get()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Produtos.ToList();
            }
        }
        //public IEnumerable<Employees> Get()
        //{
        //    using (EmployeeDBEntities entities = new EmployeeDBEntities())
        //    {
        //        return entities.Employees.ToList();
        //    }
        //}


        [HttpGet]
        [Route("api/employees/anything")]
        public IEnumerable<Employees> EmployeesByAnithing()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.Where(x=>x.Gender=="female").ToList();
            }
        }


    }
}
