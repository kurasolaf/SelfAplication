using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAplication.ViewModels
{
    public class CharacterListItemViewModel
    {
        #region Basic MetaData
        
        public int Id { get; set; }
        public bool Complete { get; set; }
        public string BasicName { get; set; }
        public int BasicLvl { get; set; }
        public string BasicRace { get; set; }
        public string BasicClass { get; set; }
        #endregion


        #region Advanced MetaData
        public string AdvancedCharacterDesc { get; set; }
        public int AdvancedWill { get; set; }
        public int AdvancedMeleAtk { get; set; }
        public int AdvancedRangedAtk { get; set; }
        public int AdvancedDodge { get; set; }
        public int AbilitiesPoints { get; set; }
        #endregion


        #region Statistic MetaData
        public int StatStrenght { get; set; }
        public int StatInteligence { get; set; }
        public int StatDexterity { get; set; }
        public int StatWisdom { get; set; }
        public int StatConstitution { get; set; }
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
