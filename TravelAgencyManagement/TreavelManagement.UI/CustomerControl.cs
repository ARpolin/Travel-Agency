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
using MetroFramework;
using ClassLibrary1;
using BussinessLogic.bll;
using TreavelManagement.UI.UC;
namespace TreavelManagement.UI
{
    public partial class CustomerControl : MetroForm
    {
        //new try 
        DataGridView _calcDataGridView;
        public CustomerControl()
        {
            InitializeComponent();
            //metroTextBox1.PasswordChar = '*';
            //metroTextBox1.MaxLength = 80;
            //newtry strat
            //_calcDataGridView = new DataGridView();
            //this.Controls.Add(_calcDataGridView);
            //_calcDataGridView.Dock = DockStyle.Top;

            //_calcDataGridView.Name = "CalcDataGridView";
            //_calcDataGridView.CellEndEdit += Calculate;

            //var aColumn = new DataGridViewTextBoxColumn();
            //aColumn.Name = "HotelCost";
            //aColumn.HeaderText = "HotelCost";
            //_calcDataGridView.Columns.Add(aColumn);

            //var bColumn = new DataGridViewTextBoxColumn();
            //bColumn.Name = "TransportCost";
            //bColumn.HeaderText = "TransportCost";
            //_calcDataGridView.Columns.Add(bColumn);

            //var totalColumn = new DataGridViewTextBoxColumn();
            //totalColumn.Name = "TotalCost";
            //totalColumn.HeaderText = "TotalCost";
            //totalColumn.ReadOnly = true;
            //_calcDataGridView.Columns.Add(totalColumn);
            //new try finish
        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tavelagencyDataSet2.AddToursTable' table. You can move, or remove it, as needed.
            this.addToursTableTableAdapter.Fill(this.tavelagencyDataSet2.AddToursTable);
            // TODO: This line of code loads data into the 'tavelagencyDataSet1.custregTable' table. You can move, or remove it, as needed.
            this.custregTableTableAdapter.Fill(this.tavelagencyDataSet1.custregTable);

        }

        private void btncustLogout_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            this.Hide();
            home.ShowDialog();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnShowTours_Click(object sender, EventArgs e)
        {
            Choose_Your_Tour choose = new Choose_Your_Tour();
            this.Hide();
            choose.ShowDialog();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnShowMyInfo_Click(object sender, EventArgs e)
        {
           
            
            
            
        }

        private void txtexp_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            ////BussinessLogic.bll.CustomerInfoLogic add = new BussinessLogic.bll.CustomerInfoLogic();
            ////metroGrid1.DataSource = add.GetInfo(metrotxtBox.Text);
            //CustomerInfoLogic cs2 = new CustomerInfoLogic();
            //if (cs2.Check1(metroTextBox1.Text))
            //{
            //    MetroMessageBox.Show(this, "OK", "Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            //}
            //else
            //{
            //    MetroMessageBox.Show(this, "Wrong password!!","Password",MessageBoxButtons.OK,MessageBoxIcon.Error);

                
            //}


            


            
        }

        private void btncustoffer_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroGridShowTours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metrotxtBox_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonShowTours_Click(object sender, EventArgs e)
        {
            BussinessLogic.bll.AddTourLogic add = new BussinessLogic.bll.AddTourLogic();
            metroGrid2.DataSource = add.AddTour(metroComboBox1.Text);
        }

        private void metroButtonConfirm_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Congratulation!! Sucessfully added!!! Happy Journey!!!!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnshowuserinfo_Click(object sender, EventArgs e)
        {
            //if (!pnluserinfo.Controls.Contains(ucUserInfo.Instance1))
            //{
            //    pnluserinfo.Controls.Add(ucUserInfo.Instance1);
            //    ucUserInfo.Instance1.Dock = DockStyle.Fill;
            //    ucUserInfo.Instance1.BringToFront();
            //}
            //else
            //{
            //    ucUserInfo.Instance1.BringToFront();
            //}

            //check and show
            LoginInfo log=new LoginInfo();
            CustomerInfoLogic show = new CustomerInfoLogic();
            custregTable show2 = new custregTable();
            //show.ShowUserInfo(show2.username);
            show2= show.ShowUserInfo("polin");
            txtusername.Text = show2.username;

            txtfirstName.Text = show2.firstname;
            txtLastname.Text = show2.lastname;
            txtage.Text = Convert.ToString (show2.age);
            txtPass.Text = show2.password;
            txtEmail.Text = show2.email;
            txtaddress.Text = show2.address;
            
           
            
           
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnluserinfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a, b;
            AddToursTable addplus = new AddToursTable();
            int result = 0;
            for (int i = 0; i < metroGrid2.RowCount; i++)
            {
                a = Convert.ToInt32(metroGrid2.Rows[i].Cells[2].Value);
                b = Convert.ToInt32(metroGrid2.Rows[i].Cells[4].Value);
                //sumunit += unit;

                txtplus.Text = Convert.ToString(a + b);

            }
        }

        private void txtfirstName_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void txtplus_Click(object sender, EventArgs e)
        {

        }
            //result /= sumunit;<br>
            // = Convert.ToInt32(a + b);
        
            //2nd
        //    for (int i = 0; i < metroGrid2.Rows.Count; i++)
        //    {
        //        if (metroGrid2 != null)
        //        {


        //            int AddHotelCost = Convert.ToInt32(metroGrid2.Rows[i].Cells[2]);
        //            int AddTransportCost = Convert.ToInt32(metroGrid2.Rows[i].Cells[4]);
        //            int k = add(AddHotelCost, AddTransportCost);
        //            MetroMessageBox.Show(this, k.ToString());
        //            txtplus.Text = k.ToString();
        //        }
        //        else
        //        {
        //            int AddHotelCost = 0;
        //            int AddTransportCost = 0;
        //        }

        //    }
        //}
        //public int add(int i, int j)
        //{
        //    return (i + j);
        //}
    
        
        //    private void Calculate(object sender, DataGridViewCellEventArgs e)
        //     {
        //    object a = _calcDataGridView.CurrentRow.Cells["HotelCost"].Value;
        //    object b = _calcDataGridView.CurrentRow.Cells["TransportCost"].Value;
        //    double aNumber = 0;
        //    double bNumber = 0;
        //    if (a != null)
        //        aNumber = Double.Parse(a.ToString());
        //    if (b != null)
        //        bNumber = Double.Parse(b.ToString());
        //    _calcDataGridView.CurrentRow.Cells["TotalCost"].Value = aNumber + bNumber;
        //}

            //private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //{

            //}

    }
}
