using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Controllers
{
    [Route("api/rarityCard")]
    [ApiController]
    public class RarityCardController : Controller
    {
        private readonly IRarityCardRepository _rarityCardRepository;

        public RarityCardController(IRarityCardRepository rarityCardRepository)
        {
            _rarityCardRepository = rarityCardRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RarityCard>> GetRarityCard()
        {
            return Ok(_rarityCardRepository.GetRarityCards());
        }

        [HttpGet("{rarityCardId}")]
        public ActionResult GetRarityCardById(int rarityCardId)
        {
            return Ok(_rarityCardRepository.GetRarityCardById(rarityCardId));
        }

        [HttpPost]
        public ActionResult Post(RarityCard rarityCard)
        {
            _rarityCardRepository.CreateRarityCard(rarityCard);

            return Ok();
        }

        [HttpPut("{rarityCardId}")]
        public ActionResult Put(int rarityCardId, RarityCard rarityCard)
        {
            _rarityCardRepository.UpdateRarityCard(rarityCardId, rarityCard);

            return NoContent();
        }

        [HttpDelete("{rarityCardId}")]
        public ActionResult Delete(int rarityCardId)
        {
            _rarityCardRepository.DeleteRarityCard(rarityCardId);

            return NoContent();
        }
    }
}
