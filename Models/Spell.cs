using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAplication.Models
{
    //podstawowa klasa, potem SelfAplicationContext podpiąć do DB (public DbSet<Spell>Spells + getset, potem EF + migracja danych/
    public class Spell
    {
        [Key]
        public int Id { get; set; }
        public string SpellName { get; set; }
        public string SpellElement { get; set; }
        public int SpellLvl {get; set;}
        public int SpellDmg { get; set; }
        public int SpellRange { get; set; }
        public int SpellCastTime { get; set; }
        public int SpellConcetration { get; set; }
        public string SpellDesc { get; set; }

    }
}
