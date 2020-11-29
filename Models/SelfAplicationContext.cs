using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace SelfAplication.Models
{
    //o co tu kaman? łączenie sie z bazą.
    public class SelfAplicationContext : DbContext
    {
        public SelfAplicationContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }


        // tu podpinam klasy "bazowe" 

        public DbSet<Character> Characters { get; set; }


    }
}
