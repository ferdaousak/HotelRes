using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservation.userControls;
namespace HotelReservation
{
    public partial class ReservationForm : Form
    {
        Model.dbReservation DB = new Model.dbReservation();
        ucChambre currentucChambre = null;
        public ReservationForm(ucChambre ucChambre)
        {
            this.currentucChambre = ucChambre;

            InitializeComponent();
            Title.Text += " "+currentucChambre.chambre.numero;
            dateReservation.Value = currentucChambre.date;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            String username = nameTextBox.Text;
            DateTime dateRes = dateReservation.Value;
            int jours = (int)nbrJoursReserv.Value;

            DB.ReservChambre(username, currentucChambre.chambre.id, dateRes, jours);

            ucHotel p = (ucHotel)currentucChambre.Parent.Parent;
            p.reload();
            this.Close();
        }
    }
}
