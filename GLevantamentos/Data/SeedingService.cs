using desafioDev.Models.Enums;
using GLevantamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLevantamentos.Data
{
    public class SeedingService
    {
        private readonly GLevantamentosContext con;

        public SeedingService(GLevantamentosContext c)
        {
            con = c;
        }

        public void Seed()
        {
            //con.ExecuteStoryQuery("DELETE User");
            State s1 = null, s2 = null, s3 = null, s4 = null, s5 = null;
            City c1 = null, c2 = null, c3 = null, c4 = null, c5 = null, c6 = null, c7 = null, c8 = null, c9 = null, c10 = null;
            User u1 = null, u2 = null, u3 = null, u4 = null, u5 = null, u6 = null, u7 = null;
            Employee e1 = null, e2 = null, e3 = null, e4 = null, e5 = null, e6 = null, e7 = null;
            Client cli1 = null, cli2 = null, cli3 = null, cli4 = null, cli5 = null, cli6 = null, cli7 = null;
            Block b1 = null, b2 = null, b3 = null, b4 = null;
            Flooring f1 = null, f2 = null, f3 = null, f4 = null;
            Equipament eq1 = null, eq2 = null, eq3 = null;
            Survey survey = null;

            if (!con.Equipament.Any())
            {
                eq1 = new Equipament(1, "Luminárias", ETypeEquipament.Iluminação, EquipamentStatus.Burnt); ;
                eq2 = new Equipament(2, "Tomadas", ETypeEquipament.Potência, EquipamentStatus.Broken);
                eq3 = new Equipament(3, "Chaves", ETypeEquipament.Potência, EquipamentStatus.Burnt);

                con.Equipament.AddRange(eq1, eq2, eq3);
                con.SaveChanges();
            }

            if (!con.Flooring.Any())
            {
                f1 = new Flooring(1, "Pavimento 001");
                f2 = new Flooring(1, "Pavimento 002");
                f3 = new Flooring(1, "Pavimento 003");
                f4 = new Flooring(1, "Pavimento 004");

                con.Flooring.AddRange(f1, f2, f3, f4);
                con.SaveChanges();
            }

            if (!con.Block.Any())
            {
                b1 = new Block(1, "Bloco 001");
                b2 = new Block(1, "Bloco 002");
                b3 = new Block(3, "Bloco 003");
                b4 = new Block(4, "Bloco A");

                con.AddRange(b1, b2, b3, b4);
                con.SaveChanges();
            }
                
            if (!con.State.Any())
            {
                s1 = new State(1, "Rio Grande do Sul", "RS");
                s2 = new State(2, "Santa Catarina", "SC");
                s3 = new State(3, "Parána", "PR");
                s4 = new State(4, "São Paulo", "SP");
                s5 = new State(5, "Rio de Janeiro", "RJ");

                con.State.AddRange(s1, s2, s3, s4, s5);
                con.SaveChanges();
            }

            if (!con.City.Any())
            {
                c1 = new City(1, "Santa Rosa", con.State.FirstOrDefault(c => c.Id == 1));
                c2 = new City(2, "Tuparendi", con.State.FirstOrDefault(c => c.Id == 1));
                c3 = new City(3, "Tucunduva", con.State.FirstOrDefault(c => c.Id == 1));
                c4 = new City(4, "Porto Alegre", con.State.FirstOrDefault(c => c.Id == 1));
                c5 = new City(5, "Itapema", con.State.FirstOrDefault(c => c.Id == 2));
                c6 = new City(6, "Florianópolis", con.State.FirstOrDefault(c => c.Id == 2));
                c7 = new City(7, "Canoinhas", con.State.FirstOrDefault(c => c.Id == 2));
                c8 = new City(8, "São Paulo", con.State.FirstOrDefault(c => c.Id == 4));
                c9 = new City(9, "Toledo", con.State.FirstOrDefault(c => c.Id == 3));
                c10 = new City(10, "Rio de Janeiro", con.State.FirstOrDefault(c => c.Id == 5));

                con.City.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10);
               con.SaveChanges();
            }

            if (!con.Client.Any())
            {
                cli1 = new Client(1, "Ed. Dona Rosinha", "eddonaros@ht.com.br", "Rua 701","(48) 9856-9966","João Acolumbre", con.City.FirstOrDefault(c => c.Id == 6));
                cli2 = new Client(2, "Ed. Dona Rosinha", "eddonaros@ht.com.br", "Rua 701","(48) 9856-9966","Marcelo Vinagre", con.City.FirstOrDefault(c => c.Id == 2));
                cli3 = new Client(3, "Ed. Dona Rosinha", "eddonaros@ht.com.br", "Rua 701","(48) 9856-9966","João De souza", con.City.FirstOrDefault(c => c.Id == 3));
                cli4 = new Client(4, "Ed. Dona Rosinha", "eddonaros@ht.com.br", "Rua 701","(48) 9856-9966","Joaquim barbosa", con.City.FirstOrDefault(c => c.Id == 3));
                cli5 = new Client(5, "Ed. Dona Rosinha", "eddonaros@ht.com.br", "Rua 701","(48) 9856-9966","Ricardo toledo", con.City.FirstOrDefault(c => c.Id == 4));
                cli6 = new Client(6, "Ed. Dona Rosinha", "eddonaros@ht.com.br", "Rua 701","(48) 9856-9966","Almir Satter", con.City.FirstOrDefault(c => c.Id == 1));
                cli7 = new Client(7, "Ed. Dona Rosinha", "eddonaros@ht.com.br", "Rua 701", "(48) 9856-9966","José Mascarennas", con.City.FirstOrDefault(c => c.Id == 1));

                con.AddRange(cli1, cli2, cli3, cli4, cli5, cli6, cli7);
                con.SaveChanges();
            }
            if (!con.User.Any())
            {
                u1 = new User(1, "Administrador", "u@u.com", "admin", "adminadmin");
                u2 = new User(2, "Convidado 1", "c1@u.com", "conv1", "conv1234567");
                u3 = new User(3, "Paulo Nogueira", "pn@u.com", "pnogueira", "123456789");
                u4 = new User(4, "Roberta Soares", "rsoares@u.com", "rosoares", "987654321");
                u5 = new User(5, "Julio de Catilhos", "jcasti@u.com", "jucastilho", "jucas12345");
                u6 = new User(6, "Geovana Tavares", "geotava@hotmail.com", "geotava", "12345678");
                u7 = new User(7, "Tamiris Rodrigues", "tamiro@u.com", "tamirod", "123123123");

                con.AddRange(u1, u2, u3, u4, u5, u6, u7);
               con.SaveChanges();
            }

            if (!con.Employee.Any())
            {
                e1 = new Employee(1, "João Almeida", "joalmeida@hotmail.com", "Rua 503,212", con.User.FirstOrDefault(c => c.Id == 1), con.City.FirstOrDefault(c => c.Id == 1));
                e2 = new Employee(2, "Joaquim Barbosa", "jocabarbo@hotmail.com", "Rua 504,5412", con.User.FirstOrDefault(c => c.Id == 2), con.City.FirstOrDefault(c => c.Id == 2));
                e3 = new Employee(3, "Paulo Nogueira", "pn@u.com", "Rua 503,212", con.User.FirstOrDefault(c => c.Id == 3), con.City.FirstOrDefault(c => c.Id == 4));
                e4 = new Employee(4, "Roberta Soares", "rsoares@u.com", "Rua Otacilio Costa,212", con.User.FirstOrDefault(c => c.Id == 4), con.City.FirstOrDefault(c => c.Id == 2));
                e5 = new Employee(5, "Julio de Catilhos", "jcasti@u.com", "Rua 1001,22", con.User.FirstOrDefault(c => c.Id == 5), con.City.FirstOrDefault(c => c.Id == 6));
                e6 = new Employee(6, "Geovana Tavares", "geotava@hotmail.com", "Rua 503,212", con.User.FirstOrDefault(c => c.Id == 6), con.City.FirstOrDefault(c => c.Id == 4));
                e7 = new Employee(7, "Tamiris Rodrigues", "tamiro@u.com", "Rua Porto Rico,212", con.User.FirstOrDefault(c => c.Id == 7), con.City.FirstOrDefault(c => c.Id == 5));

                con.AddRange(e1, e2, e3, e4, e5, e6, e7);
                con.SaveChanges();
            }

            if (!con.Survey.Any())
            {
                survey = new Survey(1,"First levantamento",cli1, u1);

                SurveyResources sres = new SurveyResources(1,survey, b1, f1, eq1);

                con.Add(survey); con.SaveChanges();
                con.Add(sres); con.SaveChanges();

            }
            
        }
    }
}
