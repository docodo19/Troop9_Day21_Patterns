using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Patterns.Data;
using Patterns.Repositories;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Patterns.API
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        private IBlogRepository _repo;
        public BlogController(IBlogRepository repo)
        {
            _repo = repo;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var blogs = _repo.GetBlogs();
            return Ok(blogs);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
