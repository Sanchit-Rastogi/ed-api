using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ED_api.Contracts;
using ED_api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ED_api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Employee emp)
        {
            if (ModelState.IsValid)
                _employeeService.Add(emp);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee emp)
        {
            emp.Id = id;
            if (ModelState.IsValid)
                _employeeService.Update(emp);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.Delete(id);
        }
    }
}
