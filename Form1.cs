using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class HotelReservationForm : Form
    {
        public userControls.ucHotel hotel { get; set; }
        public HotelReservationForm()
        {
            InitializeComponent();
            this.hotel = ucHotel1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.hotel.reload();
        }
    }
}
