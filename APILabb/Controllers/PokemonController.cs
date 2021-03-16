using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace APILabb.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {

        List<Pokemon> pokemons = new List<Pokemon>(){
            new Pokemon() {Name = "Charizard", Level = 1},
            new Pokemon() {Name = "Ditto", Level = 1}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }

        [HttpPut]
        public ActionResult Put(Pokemon pokemon)
        {
            pokemons.Add(pokemon);

            return Ok(pokemons);
        }
    }
}
