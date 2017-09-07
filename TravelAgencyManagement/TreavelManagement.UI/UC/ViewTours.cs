using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogic.bll;

namespace TreavelManagement.UI.UC
{
    public partial class ucviewTour : UserControl
    {
        private static ucviewTour _instance;
        public static ucviewTour Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucviewTour();
                return _instance;
            }
           
        }
        public ucviewTour()
        {
            InitializeComponent();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        
        }

        private void btnshowtours_Click(object sender, EventArgs e)
        {
            BussinessLogic.bll.AddTourLogic add = new BussinessLogic.bll.AddTourLogic();
            metroGridviewtours.DataSource = add.GetAllInformation();
        }

        private void metroGridviewtours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucviewTour_Load(object sender, EventArgs e)
        {

        }
    }
}
