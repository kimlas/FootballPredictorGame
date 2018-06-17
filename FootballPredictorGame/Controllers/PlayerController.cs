using System.Collections.Generic;
using Business.Repositories;
using Domain.Core;
using Microsoft.AspNetCore.Mvc;

namespace FootballGuessGame.Controllers
{
    [Produces("application/json")]
    [Route("api/Player")]
    public class PlayerController : Controller
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<Player> GetAll()
        {
            return _playerRepository.GetAll();
        }

        [HttpGet]
        [Route("Get")]
        public Player Get(int id)
        {
            return _playerRepository.Get(id);
        }

        [HttpPost]
        [Route("Add")]
        public int Add([FromBody] Player player)
        {
            _playerRepository.Add(player);

            return player.Id;
        }
    }
}