using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class TypeChambres
    {
        public static List<Model.Type> list { get; set; }

        public TypeChambres()
        {
            if(list == null)
                list = Model.dbReservation.getAllTypes();
        }
    }
}
