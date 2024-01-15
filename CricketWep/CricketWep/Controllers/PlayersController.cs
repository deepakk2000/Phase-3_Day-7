using CricketWep.Models;
using Microsoft.AspNetCore.Mvc;

namespace CricketWep.Controllers
{
    public class PlayersController : Controller
    {
        static List<Player> player = new List<Player>()
        {
            new Player(){PId=1,PName="Deep",PCountry="Maxico",Ptype="All Rounder"},
            new Player(){PId=2,PName="Jambu",PCountry="India",Ptype="Batsman"},
            new Player(){PId=1,PName="Rayar",PCountry="Pakisatan",Ptype="Bowler"},
        };
        public IActionResult Index()
        {
            return View(player);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player pro)
        {
            if (ModelState.IsValid)
            {
                player.Add(pro);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
