﻿// <auto-generated />
using System;
using GLevantamentos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GLevantamentos.Migrations
{
    [DbContext(typeof(GLevantamentosContext))]
    partial class GLevantamentosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GLevantamentos.Models.Block", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Updated_at");

                    b.HasKey("Id");

                    b.ToTable("Block");
                });

            modelBuilder.Entity("GLevantamentos.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("StateId");

                    b.Property<DateTime>("Updated_at");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("GLevantamentos.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("CityId");

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("NameResponsible");

                    b.Property<string>("Phone");

                    b.Property<DateTime>("Updated_at");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("GLevantamentos.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("CityId");

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Updated_at");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("UserId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("GLevantamentos.Models.Equipament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Description");

                    b.Property<int>("Status");

                    b.Property<int>("TypeEquipament");

                    b.Property<DateTime>("Updated_at");

                    b.HasKey("Id");

                    b.ToTable("Equipament");
                });

            modelBuilder.Entity("GLevantamentos.Models.Flooring", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Updated_at");

                    b.HasKey("Id");

                    b.ToTable("Flooring");
                });

            modelBuilder.Entity("GLevantamentos.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Name");

                    b.Property<string>("UF");

                    b.Property<DateTime>("Updated_at");

                    b.HasKey("Id");

                    b.ToTable("State");
                });

            modelBuilder.Entity("GLevantamentos.Models.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Updated_at");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("UserId");

                    b.ToTable("Survey");
                });

            modelBuilder.Entity("GLevantamentos.Models.SurveyResources", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlockId");

                    b.Property<int>("EquipamentId");

                    b.Property<int>("FlooringId");

                    b.Property<int>("SurveyId");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.HasIndex("EquipamentId");

                    b.HasIndex("FlooringId");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveyResources");
                });

            modelBuilder.Entity("GLevantamentos.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_at");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("Updated_at");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GLevantamentos.Models.City", b =>
                {
                    b.HasOne("GLevantamentos.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GLevantamentos.Models.Client", b =>
                {
                    b.HasOne("GLevantamentos.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GLevantamentos.Models.Employee", b =>
                {
                    b.HasOne("GLevantamentos.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GLevantamentos.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GLevantamentos.Models.Survey", b =>
                {
                    b.HasOne("GLevantamentos.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GLevantamentos.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GLevantamentos.Models.SurveyResources", b =>
                {
                    b.HasOne("GLevantamentos.Models.Block", "Blocks")
                        .WithMany()
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GLevantamentos.Models.Equipament", "Equipaments")
                        .WithMany()
                        .HasForeignKey("EquipamentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GLevantamentos.Models.Flooring", "Floorings")
                        .WithMany()
                        .HasForeignKey("FlooringId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GLevantamentos.Models.Survey", "Surveys")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
