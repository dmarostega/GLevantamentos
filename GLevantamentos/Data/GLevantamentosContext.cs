
using desafioDev.Models;
using GLevantamentos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Data
{
    public class GLevantamentosContext : DbContext
    {
        public GLevantamentosContext()
        { }
        public GLevantamentosContext(DbContextOptions<GLevantamentosContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Block> Block { get; set; }
        public DbSet<Flooring> Flooring { get; set; }
        // public DbSet<TypeEquipament> TypeEquipament { get; set; }

        public DbSet<Equipament> Equipament { get; set; }

        public DbSet<Survey> Survey { get; set; }
        public DbSet<SurveyResources> SurveyResources { get; set; }



    }
}
