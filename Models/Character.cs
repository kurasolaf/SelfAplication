using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAplication.Models
{
    public class Character
    {
        //Basic MetaData
        public int BasicId { get; set; }

        public string BasicName { get; set; }

        public int BasicLvl { get; set; }

        public string BasicRace { get; set; }

        public string BasicClass { get; set; }
        

        //Advanced MetaData

        public string AdvancedCharacterDesc { get; set; }
        public int AdvancedWill { get; set; }
        public int AdvancedMeleAtk { get; set; }
        public int AdvancedRangedAtk { get; set; }
        public int AdvancedDodge { get; set; }
        public int AbilitiesPoints { get; set; }
        


        //Statistic MetaData
        public int StatStrenght { get; set; }
        public int StatInteligence { get; set; }
        public int StatDexterity { get; set; }
        public int StatWisdom { get; set; }
        public int StatConstitution { get; set; }
        public int StatCharisma { get; set; }

        //Abilities MetaData
        public int AbilityConcetration { get; set; }
        public int AbilityAlchemy { get; set; }

        //Other 

        public string Inventory { get; set; }



    }
}
