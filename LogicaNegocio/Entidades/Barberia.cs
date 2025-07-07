using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Barberia
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
       
        public List<Barbero> Barberos { get; set; } = new List<Barbero>();


        public Barberia()
        {
            Id = 0;
            Name = string.Empty;
            Address = string.Empty;
            PhoneNumber = string.Empty;
           
            
        }

        public Barberia(int id, string name, string address, string phoneNumber)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        
           
        }









    }
}
