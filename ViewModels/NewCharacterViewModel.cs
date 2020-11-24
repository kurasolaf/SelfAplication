using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SelfAplication.ViewModels
{
    public class NewCharacterViewModel
    {
       
        
        #region Basic Meta Data

        [Required(ErrorMessage = "The character needs a good name or respectable though")]
        public string BasicName { get; set; }
        public int BasicLvl { get; set; }
        [Required(ErrorMessage = "Are you a racist? Pick a race!")]
        public string BasicRace { get; set; }
        [Required(ErrorMessage = "Class is also needed... or you want to be a peon?")]
        public string BasicClass { get; set; }
        #endregion


        #region Advanced MetaData
        public string AdvancedCharacterDesc { get; set; }
        public int AdvancedWill { get; set; }
        public int AdvancedBaseAtk { get; set; } 
        public int AdvancedMeleAtk { get; set; }
        public int AdvancedRangedAtk { get; set; }
        public int AdvancedDodge { get; set; }
        public int AbilitiesPoints { get; set; }
        #endregion


        #region Statistic MetaData
        [Required(ErrorMessage = "You dont want to be weak! Grab some strenght!")]
        public int StatStrenght { get; set; }
        [Required(ErrorMessage = "Dont be dumb. Any sigh of inteligence life?")]
        public int StatInteligence { get; set; }
        [Required(ErrorMessage = "You need some agility")]
        public int StatDexterity { get; set; }
        [Required(ErrorMessage = "Often wisdom comes with age... but not this time")]
        public int StatWisdom { get; set; }
        [Required(ErrorMessage = "Eat something and make some body building")]
        public int StatConstitution { get; set; }
        [Required(ErrorMessage = "Do you have any charisma?")]
        public int StatCharisma { get; set; }
        #endregion

        #region Abilities MetaData
        public int AbilityConcetration { get; set; }
        public int AbilityAlchemy { get; set; }
        #endregion

        #region Others 
        public string Inventory { get; set; }
        public int Gold { get; set; }
        #endregion


    }
}
