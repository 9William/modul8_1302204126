using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302204126.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movies : ControllerBase
    {
        private static readonly string[] Titles = new[]
                {
            "The Shawshank Redemption", "The Godfather", "The Dark Knight"
        };

        private static readonly string[] Directors = new[]
                {
            "Frank Darabont", "Francis Ford Coppola", "Christopher Nolan"
        };

        private static readonly string[] Descriptions = new[]
                {
            "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
        };

        // GET: api/<Movies>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0, 3).Select(index => new Movie
            {
               Title = Titles[index],
               Director = Directors[index],
               Stars = new List<string> {""},
               Description = Descriptions[index]
            })
            .ToArray();
        }

        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Movies>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private readonly ILogger<Movies> _logger;

        public Movies(ILogger<Movies> logger)
        {
            _logger = logger;
        }
    }
}
