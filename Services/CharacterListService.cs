using SelfAplication.Models;
using SelfAplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SelfAplication.Services
{
    public class CharacterListService
    {
        private SelfAplicationContext _context;


        public CharacterListService(SelfAplicationContext context)
        {

            _context = context;

        }

        public CharacterListViewModel GetAllOpen()
        {
            var characters = _context.Characters.Where(x => !x.Complete).Select(x => new CharacterListItemViewModel
            {
                Id = x.Id,
                BasicName = x.BasicName,
                BasicLvl = x.BasicLvl, 
                BasicRace = x.BasicRace, 
                BasicClass = x.BasicClass,
   
                AdvancedCharacterDesc = x.AdvancedCharacterDesc, 
                AdvancedWill = x.AdvancedWill,
                AdvancedMeleAtk = x.AdvancedMeleAtk,
                AdvancedRangedAtk = x.AdvancedRangedAtk,
                AdvancedDodge = x.AdvancedDodge,
                AbilitiesPoints = x.AbilitiesPoints,
  
                StatStrenght = x.StatStrenght,
                StatInteligence = x.StatInteligence,
                StatDexterity = x.StatDexterity,
                StatWisdom = x.StatWisdom,
                StatConstitution = x.StatConstitution,
                StatCharisma = x.StatCharisma,
               
                AbilityConcetration= x.AbilityConcetration,
                AbilityAlchemy = x.AbilityAlchemy,
       
                Inventory = x.Inventory,
                Gold = x.Gold
             });

            var vm = new CharacterListViewModel
            {
                Characters = characters

            };

            return vm;

            




        }


    }
}
