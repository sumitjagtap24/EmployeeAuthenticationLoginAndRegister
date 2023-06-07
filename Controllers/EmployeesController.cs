﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeAuthKud.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (senwellEntities2 entities = new senwellEntities2()) 
            {
                return entities.Employees.ToList(); 
            }
        }
    }
}
