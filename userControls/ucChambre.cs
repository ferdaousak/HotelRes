using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservation.Properties;
using Microsoft.VisualBasic;

namespace HotelReservation.userControls
{
    public partial class ucChambre : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChambre));

        public Model.Chambre chambre{get; set;}
        public DateTime date { get; set; }
        public ucChambre(Model.Chambre chambre,DateTime searchdate)
        {
            this.date = searchdate;
            this.chambre = chambre;
            InitializeComponent();

            int userReservee = Model.dbReservation.isReserved(chambre.id,date);
            lblNum.Text = "N°" + chambre.numero;

            lblReserved.Text = userReservee != -1 ? "Réservé par " + Model.dbReservation.getUsernameFromId(userReservee) : "Disponible";
            if(userReservee != -1)
            {

                this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closedDoor")));
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                BackColor = System.Drawing.Color.Red;
            }
                
            Model.TypeChambres types = new Model.TypeChambres();
            foreach(Model.Type t in Model.TypeChambres.list)
            {
                if(t.id.Equals(chambre.type_id))
                {
                    lblType.Text = "Chambre " + t.classe;
                    break;
                }
            }
        }
        private void réserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationForm resform = new ReservationForm(this);
            resform.Show();
        }

        private void libérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Voulez vous libérer la chambre ?", "Attention!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                Model.dbReservation.libererChambre(this);
                ucHotel p = (ucHotel)this.Parent.Parent;
                p.reload();
            }
        }
    }
}
