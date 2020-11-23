using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfAplication.Models;
using SelfAplication.Services;

namespace SelfAplication.Controllers
{
    public class HomeController : Controller
    {
        private CharacterListService _characterListService;

        public HomeController(CharacterListService characterListService)
        {
            _characterListService = characterListService;
        }

        public IActionResult Index()
        {
            var vm = _characterListService.GetAllOpen();

            return View(vm);
        }

        public IActionResult Finish(int id)
        {
            if (id != 0)
            {
                _characterListService.FinishCharacter(id);
            }
            return RedirectToAction("Index");
        }


    }
}
