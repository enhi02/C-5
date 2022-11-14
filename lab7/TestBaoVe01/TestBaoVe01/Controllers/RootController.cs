using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBaoVe01.Interfaces;
using TestBaoVe01.Models;

namespace TestBaoVe01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RootController : ControllerBase
    {
        private IRoot _rootSvc;

        public RootController(IRoot rootSvc)
        {
            _rootSvc = rootSvc;
        }

        [HttpGet]
        public IEnumerable<Root> Get()
        {
            return _rootSvc.GetAll();
        }

        // GET api/<RootController>/5
        [HttpGet("{id}")]
        public Root Get(int id)
        {
            return _rootSvc.GetRootId(id);
        }

        // POST api/<RootController>
        [HttpPost]
        public Root Post([FromBody] Root root)
        {
            return _rootSvc.AddRoot(root);
        }

        // PUT api/<RootController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RootController>/5
        [HttpDelete]
        public void Delete(Root root)
        {
            _rootSvc.DeleteRoot(root);
        }
    }
}
