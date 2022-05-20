using AutoMapper;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Controllers
{
    [Route("api/backpack")]
    [ApiController]
    public class BackpackController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBackpackRepository _backpackRepository;

        public BackpackController(IMapper mapper, IBackpackRepository backpackRepository)
        {
            _mapper = mapper;
            _backpackRepository = backpackRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Backpack>> GetBackpack()
        {
            return Ok(_backpackRepository.GetBackpacks());
        }

        [HttpGet("{backpackId}")]
        public ActionResult GetBackpackById(int backpackId)
        {
            return Ok(_backpackRepository.GetBackpackById(backpackId));
        }

        [HttpPost]
        public ActionResult Post(Backpack backpack)
        {
            _backpackRepository.CreateBackpack(backpack);

            return Ok();
        } 
       
        [HttpPut("{backpackId}")]
        public ActionResult Put(int backpackId, Backpack backpack)
        {
            _backpackRepository.UpdateBackpack(backpackId, backpack);

            return NoContent();
        }

        [HttpDelete("{backpackId}")]
        public ActionResult Delete(int backpackId)
        {
            _backpackRepository.DeleteBackpack(backpackId);

            return NoContent();
        }
    }
}
