using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace SelfAplication.Models
{
    //o co tu kaman? cos z baza danych o co chodzi w skladni?
    public class SelfAplicationContext : DbContext
    {
        public SelfAplicationContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Character> Characters { get; set; }


    }
}
