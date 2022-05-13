using AutoMapper;
using LeagueOfRouletteAPI.DTOs;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Controllers
{
    [Route("api/box")]
    [ApiController]
    public class BoxController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBoxRepository _boxRepository;

        public BoxController(IMapper mapper, IBoxRepository boxRepository)
        {
            _mapper = mapper;
            _boxRepository = boxRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BoxDto>> GetBox()
        {
            var cards = _boxRepository.GetBoxes();
            var cardsMapper = _mapper.Map<CardDto>(cards);

            return Ok(_boxRepository.GetBoxes());
        }

        [HttpGet("{boxId}")]
        public ActionResult GetBoxById(int boxId)
        {
            return Ok(_boxRepository.GetBoxById(boxId));
        }

        [HttpPost]
        public ActionResult Post([FromBody] BoxDto boxDto)
        {
            var box = _mapper.Map<Box>(boxDto);

            _boxRepository.CreateBox(box);

            return Ok();
        }

        [HttpPut("{boxId}")]
        public ActionResult Put(int boxId, Box box)
        {
            _boxRepository.UpdateBox(boxId, box);

            return NoContent();
        }

        [HttpDelete("{boxId}")]
        public ActionResult Delete(int boxId)
        {
            _boxRepository.DeleteBox(boxId);

            return NoContent();
        }
    }
}
