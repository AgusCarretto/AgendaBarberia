using LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.EF
{
    public class ProyectoContext : DbContext
    {

        public DbSet<Barbero> Barberos { get; set; }

        public DbSet<Barberia> Barberias { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Turno> Turnos { get; set; }

        //public class ProyectoContextFactory : IDesignTimeDbContextFactory<ProyectoContext>
        //{
        //    public ProyectoContext CreateDbContext(string[] args)
        //    {
        //        var optionsBuilder = new DbContextOptionsBuilder<ProyectoContext>();

        //        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BarberiaProject;Integrated Security=True;Encrypt=False");

        //        return new ProyectoContext(optionsBuilder.Options);
        //    }
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                string cadenaConexion = @"Server=(localdb)\MSSQLLocalDB;Database=BarberiaProject;Integrated Security=True;Encrypt=False";
                optionsBuilder.UseSqlServer(cadenaConexion);
            }


        }

        //public ProyectoContext(DbContextOptions<ProyectoContext> options) : base(options)
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Barbero>();
            modelBuilder.Entity<Barberia>();
            modelBuilder.Entity<Cliente>();
            modelBuilder.Entity<Turno>();

        }
    }

}