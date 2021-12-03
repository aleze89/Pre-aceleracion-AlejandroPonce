using ChallengeDisney.Context;
using ChallengeDisney.Models;
using DocumentFormat.OpenXml.ExtendedProperties;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChallengeDisney.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly DisneyContext _context;
        public CharactersController(DisneyContext context)
        {
            _context = context;
        }
        // GET: api/<CharactersController>
        [HttpGet]
        public IEnumerable<string> Get(string Image, string Name)
        {
            return new string[] { Image, Name };
        }

        // GET api/<CharactersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CharactersController>
        [HttpPost]
        public IActionResult Post(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();
            return Ok(_context.Characters.ToList());
        }

        // PUT api/<CharactersController>/5
        [HttpPut]

        public IActionResult Put(Character character)
        {
            if (_context.Characters.FirstOrDefault(x => x.CharacterId == character.CharacterId) == null) return BadRequest("El Personaje enviado no existe.");
            _context.Characters.Add(character);
            _context.SaveChanges();
            return Ok(_context.Characters.ToList());
        }


        // DELETE api/<CharactersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
