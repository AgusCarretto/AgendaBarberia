using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Barbero
    {

        public int Id { get; set; }
        public string name { get; set; }
        public string lastName{ get; set; }
        public string phoneNumber { get; set; }
        public string eMail { get; set; }
        public DateTime birthOfDate { get; set; }
        public bool Active { get; set; }


        public Barbero()
        {
            Id = 0;
            name = string.Empty;
            lastName = string.Empty;
            phoneNumber = string.Empty;
            eMail = string.Empty;
            birthOfDate = DateTime.MinValue;
            Active = true;
        }

        public Barbero(int id, string name, string lastName, string phoneNumber, string eMail, DateTime birthOfDate, bool active)
        {
            Id = id;
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.eMail = eMail;
            this.birthOfDate = birthOfDate;
            Active = active;
        }



        



    }
}
