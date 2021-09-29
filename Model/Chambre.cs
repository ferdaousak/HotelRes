using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Chambre
    {
        public int id { get; set; }
        public int type_id { get; set; }
        public String numero { get; set; }
        public Chambre(int type, string numero)
        {
            this.type_id = type;
            this.numero = numero;
        }
        public Chambre(int id, int type, string numero)
        {
            this.id = id;
            this.type_id = type;
            this.numero = numero;
        }
        public Chambre()
        {
        }
    }
}
