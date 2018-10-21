using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Catan.DBL;
using Catan.Clases;
using Catan.Interfaces;

namespace Catan.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                var users = db.Users.ToList();
                return Ok(users);
            }
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                var user = db.Users.First( (u) => u.Id == id);
                return Ok(user);
            }
        }

        // POST api/users/register
        [HttpPost("register")]
        public ActionResult<User> Post([FromBody] User prms)
        {
            User user = new User
            {
                Name = prms.Name,
                Token = Guid.NewGuid()
            };

            DBLMethods.AddUser(user);

            return Ok(user);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    [Route("api/games")]
    public class GamesController: ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                var games = db.Games.ToList();
                return Ok(games);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                var game = db.Games.First((g) => g.Id == id);
                return Ok(game);
            }
        }

        [HttpPost("join")]
        public ActionResult<string> Join([FromBody] Join prms)
        {
            try
            {
                var game = DBLMethods.JoinGame(prms);
                return Ok(game);
            }
            catch
            {
                return BadRequest("There is no free space in this game");
            }
        }

        [HttpPost]
        public ActionResult<Guid> CreateGame([FromBody] User prms) {
            var game = DBLMethods.CreateGame(prms.Token);
            return Ok(game.Id);
        }
    }

    [Route("api/land")]
    public class GameController: ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            var gridList = DBLMethods.GetCurrentBoard(id);
            return Ok(gridList);
        }

        [HttpGet("{id}/{position}")]
        public ActionResult<string> Get(Guid id, int position)
        {
            var gridList = DBLMethods.GetCurrentBoard(id);
            var related = IslandGrid.GetGeksByPosition(position);
            List<IGeks> current = new List<IGeks>();

            foreach ( var key in related) {
                current.Add(gridList[key]);
            }

            return Ok(current);
        }


        [HttpGet]
        public ActionResult<Guid> Get()
        {
            Island island = new Island();
            Land land = island.GetLand();
            DBLMethods.SaveLand(land);

            return Ok(land.Id);
        }
    }
    [Route("api/game")]
    public class ProcessController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            var gridList = DBLMethods.GetCurrentBoard(id);
            var gameProcess = DBLMethods.GetGameStatus(id);

            return Ok(gameProcess);
        }
    }

}
