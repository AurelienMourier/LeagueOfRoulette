using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Controllers
{
    [Route("api/stateBox")]
    [ApiController]
    public class StateBoxController : Controller
    {
        private readonly IStateBoxRepository _stateBoxRepository;

        public StateBoxController(IStateBoxRepository stateBoxRepository)
        {
            _stateBoxRepository = stateBoxRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<StateBox>> GetStatesBox()
        {
            return Ok(_stateBoxRepository.GetStatesBox());
        }

        [HttpGet("{stateBoxId}")]
        public ActionResult GetStateBoxById(int stateBoxId)
        {
            return Ok(_stateBoxRepository.GetStateBoxById(stateBoxId));
        }

        [HttpPost]
        public ActionResult Post(StateBox stateBox)
        {
            _stateBoxRepository.CreateStateBox(stateBox);

            return Ok();
        }

        [HttpPut("{stateBoxId}")]
        public ActionResult Put(int stateBoxId, StateBox stateBox)
        {
            _stateBoxRepository.UpdateStateBox(stateBoxId, stateBox);

            return NoContent();
        }

        [HttpDelete("{stateBoxId}")]
        public ActionResult Delete(int stateBoxId)
        {
            _stateBoxRepository.DeleteStateBox(stateBoxId);

            return NoContent();
        }
    }
}
