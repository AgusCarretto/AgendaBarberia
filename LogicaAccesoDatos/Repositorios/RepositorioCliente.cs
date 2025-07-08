using LogicaAccesoDatos.EF;
using LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioCliente
    {


        public ProyectoContext context { get; set; }

        public RepositorioCliente()
        {
            this.context = new ProyectoContext();
        }

        public void Add(Cliente cliente)
        {

            cliente.validar();
            if (!this.Existe(cliente))
            {
            context.Clientes.Add(cliente);
            context.SaveChanges();
            }
            else
            {
                throw new Exception("Este mail ya esta en uso.");
            }
        }

        public void Delete(Cliente cliente)
        {
            if (cliente != null && this.Existe(cliente))
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
            else 
            {
                throw new Exception("El cliente no existe.");
            }

        }

        public void Edit(Cliente cliente)
        {
            cliente.validar();
            if (this.Existe(cliente))
            {
                context.Clientes.Update(cliente);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("El cliente no existe.");
            }
        }


            public List<Cliente> GetAll()
        {
            return context.Clientes.ToList();
        }

        public Cliente GetById(int id)
        {
            return context.Clientes.Find(id);
        }

        public Cliente GetByMail(string mail)
        {
            return context.Clientes.FirstOrDefault(c => c.eMail == mail);

        }



        public bool Existe(Cliente cliente)
        {
            return context.Clientes.Any(c => c.eMail == cliente.eMail);
        }


    }
}
