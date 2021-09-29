using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Type
    {
        public int id { get; set; }
        public String classe { get; set; }
        public Type(string classe)
        {
            this.classe = classe;
        }
        public Type(int id, string classe)
        {
            this.id = id;
            this.classe = classe;
        }
        public Type()
        {
        }
    }
}
