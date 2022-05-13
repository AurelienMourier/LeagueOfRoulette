using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Controllers
{
    [Route("api/typeCard")]
    [ApiController]
    public class TypeCardController : Controller
    {
        private readonly ITypeCardRepository _typeCardRepository;

        public TypeCardController(ITypeCardRepository TypeCardRepository)
        {
            _typeCardRepository = TypeCardRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TypeCard>> GetTypeCard()
        {
            return Ok(_typeCardRepository.GetTypeCards());
        }

        [HttpGet("{typeCardId}")]
        public ActionResult GetTypeCardById(int typeCardId)
        {
            return Ok(_typeCardRepository.GetTypeCardById(typeCardId));
        }

        [HttpPost]
        public ActionResult Post(TypeCard typeCard)
        {
            _typeCardRepository.CreateTypeCard(typeCard);

            return Ok();
        }

        [HttpPut("{typeCardId}")]
        public ActionResult Put(int typeCardId, TypeCard typeCard)
        {
            _typeCardRepository.UpdateTypeCard(typeCardId, typeCard);

            return NoContent();
        }

        [HttpDelete("{typeCardId}")]
        public ActionResult Delete(int typeCardId)
        {
            _typeCardRepository.DeleteTypeCard(typeCardId);

            return NoContent();
        }
    }
}
