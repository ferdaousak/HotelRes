using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservation.Model;

namespace HotelReservation.userControls
{
    public partial class ucHotel : UserControl
    {
        dbReservation DB = new dbReservation();
        public static List<Chambre> chambres { get; set; }
        public ucHotel()
        {
            InitializeComponent();

            loadData();
        }
        public List<Chambre> loadData()
        {
            chambres = DB.GetAllChambres();

            Console.WriteLine("chambres : {0}", chambres);

            int i = 0, j = 0;
            foreach (Chambre c in chambres)
            {
                ChambresPanel.Controls.Add(new ucChambre(c,date.Value), j, i);
                i = (i == 4) ? 0 : i++;
                j = (j == 2) ? 0 : j++;
            }

            ChambresPanel.AutoSize = true;

            return chambres;
        }

        public void reload()
        {
            ChambresPanel.Controls.Clear();
            loadData();

            Refresh();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            reload();
        }
    }
}
