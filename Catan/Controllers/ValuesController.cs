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
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                var users = db.Users.ToList();
                return Ok(users);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            using (DatabaseLayer db = new DatabaseLayer())
            {
                var user = db.Users.First( (u) => u.Id == id);
                return Ok(user);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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

        [HttpPost]
        public ActionResult<Guid> Post() {
            using (DatabaseLayer db = new DatabaseLayer()) {
                Game game = new Game(){ Id = Guid.NewGuid(), Active = true };
                db.Add(game);
                db.SaveChanges();
                return Ok(game.Id);
            }
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
}
