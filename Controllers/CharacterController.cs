using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelfAplication.Services;
using SelfAplication.ViewModels;

namespace SelfAplication.Controllers
{
    [Route("[controller]")]
    public class CharacterController : Controller
    {
        private CharacterListService _characterListService;
        public CharacterController(CharacterListService characterListService)
        {
            _characterListService = characterListService;
        }

       [HttpGet("Add")]
       public IActionResult GetAddPage()
        {
            return View();

        }

       [HttpPost]
        public IActionResult Add(NewCharacterViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            _characterListService.Add(data.BasicName, data.BasicLvl, data.BasicRace, data.BasicClass, data.AdvancedCharacterDesc, data.AdvancedWill,
                data.AdvancedBaseAtk, data.AdvancedMeleAtk, data.AdvancedRangedAtk, data.AdvancedDodge, data.AbilitiesPoints,
                data.StatStrenght, data.StatInteligence, data.StatDexterity, data.StatWisdom, data.StatConstitution, data.StatCharisma,
                data.AbilityConcetration, data.AbilityAlchemy, data.Inventory, data.Gold);

            return RedirectToAction("Index", "Home");
        }

    }
}
