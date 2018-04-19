using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace WebApiApp.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employees> Get()
        {
            using(EmployeeDBEntites entites = new EmployeeDBEntites())
            {
                return entites.Employees.ToList();
            }
        }

        public EmployeesGet()
        {
            using (EmployeeDBEntites entites = new EmployeeDBEntites())
            {
                return entites.Employees.FirstOfDefault(e => e.ID == id);
            }
        }
    }
}
