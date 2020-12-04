using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1
{
    public class Db : DbContext
    {
        public DbSet<Vehiculo> vechiculos { get; set; }
        public DbSet<Persona> personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source= Parcial1");
    }

    public class Vehiculo
    {
        public int vehiculoid { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public string descripcion { get; set; }

        public List<Persona> personas { get; } = new List<Persona>();

    }

    public class Persona
    {
        public int personaid { get; set; }
        public string cedula  { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string lugar { get; set; }

        public Vehiculo vehiculo { get; set; }

    }


}
