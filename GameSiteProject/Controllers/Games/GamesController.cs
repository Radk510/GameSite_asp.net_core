using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GameSiteProject.Controllers.Games
{
    public class GamesController : Controller
    {
        public IActionResult RockPaperScissors()
        {
            return View();
        }
    }
}
