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

        //??
        public CharacterListService(SelfAplicationContext context)
        {

            _context = context;

        }
        // o co kaman, getallopen - pobiera wszystkie niezakonczone  characters (te ktore są instacją klasy character). logika biznesowa
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
                AdvancedBaseAtk = x.AdvancedBaseAtk,
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
        // czemu tworzy sie "o co kaman"
            var vm = new CharacterListViewModel
            {
                Characters = characters

            };

            return vm;


         }

        internal void Add(string basicName, int basicLvl, string basicRace, string advancedCharacterDesc, int advancedWill, int advancedBaseAtk, int advancedMeleAtk, int advancedRangedAtk, int advancedDodge, int abilitiesPoints, int statStrenght, int statInteligence, int statDexterity, int statWisdom, int statConstitution, int statCharisma, int abilityConcetration, int abilityAlchemy, string inventory, int gold)
        {
            throw new NotImplementedException();
        }

        //wymaga wprowadzenia wszystkich zmiennych tożsamych z character. kolejnosc ma znaczenie. lepie zastąpić wzorem z NewCharacterViewModel wstzyknietym
        public void Add( string basicname, int basiclvl, string basicrace, string basicclass,
        string advancedcharacterdesc, int advancedwill, int advancedbaseatk, int advancedmeleatk, int advancedrangedatk,
        int advanceddodge, int abilitiespoints, int statstrenght, int statinteligence, int statdexterity, int statwisdom,
        int statconstitution, int statcharisma, int abilityconcetration, int abilityalchemy, string inventory, int gold)
        {
            // tworzenie instancji klasy character, gdzie przypisano do zmiennych z class character zmienne w instanji character
            var character = new Character
            {

                BasicName = basicname,
                BasicLvl = basiclvl,
                BasicRace = basicrace,
                BasicClass = basicclass,

                AdvancedCharacterDesc = advancedcharacterdesc,
                AdvancedWill = advancedwill,
                AdvancedBaseAtk = advancedbaseatk,
                AdvancedMeleAtk = advancedmeleatk,
                AdvancedRangedAtk = advancedrangedatk,
                AdvancedDodge = advanceddodge,
                AbilitiesPoints = abilitiespoints,

                StatStrenght = statstrenght,
                StatInteligence = statinteligence,
                StatDexterity = statdexterity,
                StatWisdom = statwisdom,
                StatConstitution = statconstitution,
                StatCharisma = statcharisma,

                AbilityConcetration = abilityconcetration,
                AbilityAlchemy = abilityalchemy,

                Inventory = inventory,
                Gold = gold,
                Complete = false

            };

            // najpierw czemu add? potem rozumiem ze zapisuje zmiany/ gdzie?
            _context.Characters.Add(character);
            _context.SaveChanges();

        }
        //klasa ktora konczy co? po zakonczeniu ustawia w instancji klasy character.metodaComplete wartość na true i zapisuje zmiany
        public void FinishCharacter(int id)
        {
            var character = _context.Characters.Find(id);
            character.Complete = true;
            _context.Characters.Update(character);
            _context.SaveChanges();

        }





    }
}
