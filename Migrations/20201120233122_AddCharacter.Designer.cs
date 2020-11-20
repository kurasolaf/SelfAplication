﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelfAplication.Models;

namespace SelfAplication.Migrations
{
    [DbContext(typeof(SelfAplicationContext))]
    [Migration("20201120233122_AddCharacter")]
    partial class AddCharacter
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SelfAplication.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AbilitiesPoints")
                        .HasColumnType("int");

                    b.Property<int>("AbilityAlchemy")
                        .HasColumnType("int");

                    b.Property<int>("AbilityConcetration")
                        .HasColumnType("int");

                    b.Property<string>("AdvancedCharacterDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdvancedDodge")
                        .HasColumnType("int");

                    b.Property<int>("AdvancedMeleAtk")
                        .HasColumnType("int");

                    b.Property<int>("AdvancedRangedAtk")
                        .HasColumnType("int");

                    b.Property<int>("AdvancedWill")
                        .HasColumnType("int");

                    b.Property<string>("BasicClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BasicLvl")
                        .HasColumnType("int");

                    b.Property<string>("BasicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BasicRace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inventory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatCharisma")
                        .HasColumnType("int");

                    b.Property<int>("StatConstitution")
                        .HasColumnType("int");

                    b.Property<int>("StatDexterity")
                        .HasColumnType("int");

                    b.Property<int>("StatInteligence")
                        .HasColumnType("int");

                    b.Property<int>("StatStrenght")
                        .HasColumnType("int");

                    b.Property<int>("StatWisdom")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}