using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatCardController : Controller
    {
        private readonly IStatCardRepository _statCardRepository;

        public StatCardController(IStatCardRepository statCardRepository)
        {
            _statCardRepository = statCardRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<StatCard>> GetStatCard()
        {
            return Ok(_statCardRepository.GetStatCards());
        }

        [HttpGet("{statCardId}")]
        public ActionResult GetStatCardById(int statCardId)
        {
            return Ok(_statCardRepository.GetStatCardById(statCardId));
        }

        [HttpPost]
        public ActionResult Post(StatCard statCard)
        {
            _statCardRepository.CreateStatCard(statCard);

            return Ok();
        }

        [HttpPut("{statCardId}")]
        public ActionResult Put(int statCardId, StatCard statCard)
        {
            _statCardRepository.UpdateStatCard(statCardId, statCard);

            return NoContent();
        }

        [HttpDelete("{statCardId}")]
        public ActionResult Delete(int statCardId)
        {
            _statCardRepository.DeleteStatCard(statCardId);

            return NoContent();
        }
    }
}
