using LogicaAccesoDatos.EF;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    internal class RepositorioBarbero
    {


        public ProyectoContext context { get; set; }

        public RepositorioBarbero()
        {
            this.context = new ProyectoContext();
        }

        public void Add(Barbero barbero)
        {

            barbero.validar();
            if (!this.Existe(barbero))
            {
                context.Barberos.Add(barbero);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Este mail ya esta en uso.");
            }
        }

        public void Delete(Barbero barbero)
        {
            if (barbero != null && this.Existe(barbero))
            {
                context.Barberos.Remove(barbero);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("El barbero no existe.");
            }

        }

        public void Edit(Barbero barbero)
        {
            barbero.validar();
            if (this.Existe(barbero))
            {
                context.Barberos.Update(barbero);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("El barbero no existe.");
            }
        }


        public List<Barbero> GetAll()
        {
            return context.Barberos.ToList();
        }

        public Barbero GetById(int id)
        {
            return context.Barberos.Find(id);
        }

        public Barbero GetByMail(string mail)
        {
            return context.Barberos.FirstOrDefault(b => b.eMail == mail);

        }



        public bool Existe(Barbero barbero)
        {
            return context.Barberos.Any(b => b.eMail == barbero.eMail);
        }


    }
}

