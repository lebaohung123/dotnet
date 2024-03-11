using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character{Id = 1,Name = "Sammy"},
            new Character(),
            new Character(),
            new Character(),
        };
        [HttpGet("GetAll")]
        public ActionResult<Character> Get(){
            return Ok(characters); 
        }
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.Id == id)); 
        }
        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter){
            Console.WriteLine(newCharacter);
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}