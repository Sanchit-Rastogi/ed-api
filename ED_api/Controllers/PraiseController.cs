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
    public class PraiseController : Controller
    {

        private readonly IPraiseService _praiseService;

        public PraiseController(IPraiseService praiseService)
        {
            _praiseService = praiseService;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Praise> Get()
        {
            return _praiseService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Praise Get(int id)
        {
            return _praiseService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Praise praise)
        {
            if (ModelState.IsValid)
                _praiseService.Add(praise);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Praise praise)
        {
            praise.Id = id;
            if (ModelState.IsValid)
                _praiseService.Update(praise);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _praiseService.Delete(id);
        }
    }
}
