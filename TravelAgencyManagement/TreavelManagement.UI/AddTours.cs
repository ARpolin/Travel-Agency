using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogic.bll;
using ClassLibrary1;
using MetroFramework;


namespace TreavelManagement.UI
{
    public partial class pageAddTours : MetroForm
    {
        public pageAddTours()
        {
            InitializeComponent();
        }

        private void AddTours_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AdminControl admincontrol = new AdminControl();
            this.Hide();
            admincontrol.ShowDialog();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTourLogic confirmTour = new AddTourLogic();
            AddToursTable objaddtourstable = new AddToursTable();
            if (!string.IsNullOrEmpty(txtAddTours.Text) &&
                !string.IsNullOrEmpty(metroComboBox1.Text) &&
                !string.IsNullOrEmpty(txtHotelprice.Text) &&
                !string.IsNullOrEmpty(metroComboBox2.Text) &&
                !string.IsNullOrEmpty(metroComboBox3.Text) &&
                !string.IsNullOrEmpty(txtTransportcost.Text))
            {
                var addtours = txtAddTours.Text.Trim();
                var addhotel = metroComboBox1.Text.Trim();
                var hotelprice = txtHotelprice.Text.Trim();
                var location = metroComboBox2.Text.Trim();
                var destination = metroComboBox3.Text.Trim();
                var transportcost = txtTransportcost.Text.Trim();

                objaddtourstable.AddTour = addtours;
                objaddtourstable.AddHotel = addhotel;
                objaddtourstable.AddHotelCost = hotelprice;
                objaddtourstable.AddLocation = location;
                objaddtourstable.AddDestination = destination;
                objaddtourstable.Selecttransport = CmbTransport.Text;
                objaddtourstable.AddTransportCost = transportcost;

                confirmTour.AddTour(objaddtourstable);
                



                MetroMessageBox.Show(this, "Saved");

            }
            else
            {
                MetroMessageBox.Show(this, "You Need To FillUp All Field");

            }


        }
    }
}
