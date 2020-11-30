using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace SelfAplication.Models
{
    // łączenie sie z bazą. wtedy używamy opcji klass z DbContext/
    public class SelfAplicationContext : DbContext
    {
        public SelfAplicationContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }


        // tu podpinam klasy "bazowe" 

        public DbSet<Character> Characters { get; set; }

        public DbSet<Spell> Spells { get; set; }

    }
}
