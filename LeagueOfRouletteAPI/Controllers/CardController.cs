using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Controllers
{
    [Route("api/card")]
    [ApiController]
    public class CardController : Controller
    {
        private readonly ICardRepository _cardRepository;

        public CardController(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Card>> GetCard()
        {
            return Ok(_cardRepository.GetCards());
        }

        [HttpGet("{cardId}")]
        public ActionResult GetCardById(int cardId)
        {
            return Ok(_cardRepository.GetCardById(cardId));
        }

        [HttpPost]
        public ActionResult Post(Card card)
        {
            _cardRepository.CreateCard(card);

            return Ok();
        }

        [HttpPut("{cardId}")]
        public ActionResult Put(int cardId, Card card)
        {
            _cardRepository.UpdateCard(cardId, card);

            return NoContent();
        }

        [HttpDelete("{cardId}")]
        public ActionResult Delete(int cardId)
        {
            _cardRepository.DeleteCard(cardId);

            return NoContent();
        }
    }
}
