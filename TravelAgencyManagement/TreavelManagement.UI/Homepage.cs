using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using TreavelManagement.UI.UC;

namespace TreavelManagement.UI
{
    public partial class Homepage : MetroForm
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            CustomerRegistration customerReg = new CustomerRegistration();
            this.Hide();
            customerReg.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogIn login = new btnLogIn();
            this.Hide();
            login.ShowDialog();
            if (!pnlmain.Controls.Contains(ucviewTour.Instance))
            {
                pnlmain.Controls.Add(ucviewTour.Instance);
                ucviewTour.Instance.Dock = DockStyle.Fill;
                ucviewTour.Instance.BringToFront();
            }
            else
            {
                ucviewTour.Instance.BringToFront();
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            HomeHelp homehelp = new HomeHelp();
            homehelp.ShowDialog();
            homehelp.Dispose();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //ViewTours view = new ViewTours();
            //this.Hide();
            //view.ShowDialog();
            if (!pnlmain.Controls.Contains(ucviewTour.Instance))
            {
                pnlmain.Controls.Add(ucviewTour.Instance);
                ucviewTour.Instance.Dock = DockStyle.Fill;
                ucviewTour.Instance.BringToFront();
            }
            else
            {
                ucviewTour.Instance.BringToFront();
            }
          
        }

        private void btnHomeSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
        }

        private void btnHomeContactinfo_Click(object sender, EventArgs e)
        {
           
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
