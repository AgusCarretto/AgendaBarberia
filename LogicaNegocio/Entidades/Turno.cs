using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Turno
    {

        public int Id { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [Required]
        public int IdBarbero { get; set; }

        [Required]
        public int IdCliente { get; set; }

        public Turno()
        {
            
        }

        public Turno(int id, DateTime fechaHora, int idBarbero, int idCliente)
        {
            Id = id;
            FechaHora = fechaHora;
            IdBarbero = idBarbero;
            IdCliente = idCliente;
        }

        public void validations()
        {
            dateValidation();
            
        }
        private void dateValidation()
        {

            if (this.FechaHora.Day <= DateTime.Today.Day)
            {
                throw new ArgumentException("La fecha debe ser posterior a la fecha actual.");

            }


        }

    }
}
