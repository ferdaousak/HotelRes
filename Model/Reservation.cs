using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Reservation
    {
        public int id { get; set; }
        public DateTime dateReservation { get; set; }
        public int duree { get; set; }
        public Reservation(int id, DateTime dateReservation, int duree)
        {
            this.id = id;
            this.dateReservation = dateReservation;
            this.duree = duree;
        }
        public Reservation(DateTime dateReservation, int duree)
        {
            this.dateReservation = dateReservation;
            this.duree = duree;
        }
        public Reservation()
        {
        }
    }
}
