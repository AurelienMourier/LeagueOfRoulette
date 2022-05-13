using AutoMapper;
using LeagueOfRouletteAPI.DTOs;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
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
        private readonly IMapper _mapper;
        private readonly ICardRepository _cardRepository;

        public CardController(IMapper mapper, ICardRepository cardRepository)
        {
            _mapper = mapper;
            _cardRepository = cardRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CardDto>> GetCard()
        {
            var cards = _cardRepository.GetCards();
            var cardsMapped = _mapper.Map<IEnumerable<CardDto>>(cards);

            return Ok(cardsMapped);
        }

        [HttpGet("{cardId}")]
        public ActionResult GetCardById(int cardId)
        {
            return Ok(_cardRepository.GetCardById(cardId));
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreateCardDto cardDto)
        {
            var card = _mapper.Map<Card>(cardDto);
                
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
