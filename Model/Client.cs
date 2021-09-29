using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Client
    {
        public int id { get; set; }
        public String nom { get; set; }

        public Client()
        {
        }

        public Client(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public Client(string nom)
        {
            this.nom = nom;
        }
    }
}
