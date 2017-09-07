namespace TreavelManagement.UI
{
    partial class CustomerControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncustLogout = new MetroFramework.Controls.MetroButton();
            this.btnShowTours = new MetroFramework.Controls.MetroButton();
            this.custregTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tavelagencyDataSet1 = new TreavelManagement.UI.tavelagencyDataSet1();
            this.custregTableTableAdapter = new TreavelManagement.UI.tavelagencyDataSet1TableAdapters.custregTableTableAdapter();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.addToursTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tavelagencyDataSet2 = new TreavelManagement.UI.tavelagencyDataSet2();
            this.addToursTableTableAdapter = new TreavelManagement.UI.tavelagencyDataSet2TableAdapters.AddToursTableTableAdapter();
            this.metroButtonConfirm = new MetroFramework.Controls.MetroButton();
            this.metroButtonShowTours = new MetroFramework.Controls.MetroButton();
            this.btnshowuserinfo = new MetroFramework.Controls.MetroButton();
            this.pnluserinfo = new MetroFramework.Controls.MetroPanel();
            this.txtage = new MetroFramework.Controls.MetroTextBox();
            this.txtaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.txtfirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.LabEmail = new MetroFramework.Controls.MetroLabel();
            this.labAddress = new MetroFramework.Controls.MetroLabel();
            this.labpass = new MetroFramework.Controls.MetroLabel();
            this.labAge = new MetroFramework.Controls.MetroLabel();
            this.lablastname = new MetroFramework.Controls.MetroLabel();
            this.labfirstname = new MetroFramework.Controls.MetroLabel();
            this.labusername = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtplus = new MetroFramework.Controls.MetroTextBox();
            this.addTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecttransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTransportCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.custregTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet2)).BeginInit();
            this.pnluserinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // btncustLogout
            // 
            this.btncustLogout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btncustLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustLogout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btncustLogout.Location = new System.Drawing.Point(734, 64);
            this.btncustLogout.Name = "btncustLogout";
            this.btncustLogout.Size = new System.Drawing.Size(102, 25);
            this.btncustLogout.Style = MetroFramework.MetroColorStyle.Blue;
            this.btncustLogout.TabIndex = 2;
            this.btncustLogout.Text = "Logout";
            this.btncustLogout.UseCustomBackColor = true;
            this.btncustLogout.UseCustomForeColor = true;
            this.btncustLogout.UseSelectable = true;
            this.btncustLogout.UseStyleColors = true;
            this.btncustLogout.Click += new System.EventHandler(this.btncustLogout_Click);
            // 
            // btnShowTours
            // 
            this.btnShowTours.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnShowTours.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowTours.Location = new System.Drawing.Point(620, 64);
            this.btnShowTours.Name = "btnShowTours";
            this.btnShowTours.Size = new System.Drawing.Size(110, 25);
            this.btnShowTours.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnShowTours.TabIndex = 7;
            this.btnShowTours.Text = "Show Tours";
            this.btnShowTours.UseCustomBackColor = true;
            this.btnShowTours.UseCustomForeColor = true;
            this.btnShowTours.UseMnemonic = false;
            this.btnShowTours.UseSelectable = true;
            this.btnShowTours.UseStyleColors = true;
            this.btnShowTours.Click += new System.EventHandler(this.btnShowTours_Click);
            // 
            // custregTableBindingSource
            // 
            this.custregTableBindingSource.DataMember = "custregTable";
            this.custregTableBindingSource.DataSource = this.tavelagencyDataSet1;
            // 
            // tavelagencyDataSet1
            // 
            this.tavelagencyDataSet1.DataSetName = "tavelagencyDataSet1";
            this.tavelagencyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custregTableTableAdapter
            // 
            this.custregTableTableAdapter.ClearBeforeFill = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.addToursTableBindingSource;
            this.metroComboBox1.DisplayMember = "AddTour";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(23, 228);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(193, 29);
            this.metroComboBox1.TabIndex = 17;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // addToursTableBindingSource
            // 
            this.addToursTableBindingSource.DataMember = "AddToursTable";
            this.addToursTableBindingSource.DataSource = this.tavelagencyDataSet2;
            // 
            // tavelagencyDataSet2
            // 
            this.tavelagencyDataSet2.DataSetName = "tavelagencyDataSet2";
            this.tavelagencyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addToursTableTableAdapter
            // 
            this.addToursTableTableAdapter.ClearBeforeFill = true;
            // 
            // metroButtonConfirm
            // 
            this.metroButtonConfirm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroButtonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonConfirm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroButtonConfirm.Location = new System.Drawing.Point(715, 409);
            this.metroButtonConfirm.Name = "metroButtonConfirm";
            this.metroButtonConfirm.Size = new System.Drawing.Size(121, 30);
            this.metroButtonConfirm.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonConfirm.TabIndex = 19;
            this.metroButtonConfirm.Text = "Confirm";
            this.metroButtonConfirm.UseCustomBackColor = true;
            this.metroButtonConfirm.UseCustomForeColor = true;
            this.metroButtonConfirm.UseSelectable = true;
            this.metroButtonConfirm.UseStyleColors = true;
            this.metroButtonConfirm.Click += new System.EventHandler(this.metroButtonConfirm_Click);
            // 
            // metroButtonShowTours
            // 
            this.metroButtonShowTours.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroButtonShowTours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonShowTours.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonShowTours.Location = new System.Drawing.Point(235, 229);
            this.metroButtonShowTours.Name = "metroButtonShowTours";
            this.metroButtonShowTours.Size = new System.Drawing.Size(121, 28);
            this.metroButtonShowTours.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonShowTours.TabIndex = 20;
            this.metroButtonShowTours.Text = "Choose Your Tour";
            this.metroButtonShowTours.UseCustomBackColor = true;
            this.metroButtonShowTours.UseCustomForeColor = true;
            this.metroButtonShowTours.UseSelectable = true;
            this.metroButtonShowTours.UseStyleColors = true;
            this.metroButtonShowTours.Click += new System.EventHandler(this.metroButtonShowTours_Click);
            // 
            // btnshowuserinfo
            // 
            this.btnshowuserinfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnshowuserinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowuserinfo.DisplayFocus = true;
            this.btnshowuserinfo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnshowuserinfo.Highlight = true;
            this.btnshowuserinfo.Location = new System.Drawing.Point(23, 63);
            this.btnshowuserinfo.Name = "btnshowuserinfo";
            this.btnshowuserinfo.Size = new System.Drawing.Size(130, 23);
            this.btnshowuserinfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnshowuserinfo.TabIndex = 21;
            this.btnshowuserinfo.Text = "Show User Info";
            this.btnshowuserinfo.UseCustomBackColor = true;
            this.btnshowuserinfo.UseCustomForeColor = true;
            this.btnshowuserinfo.UseSelectable = true;
            this.btnshowuserinfo.UseStyleColors = true;
            this.btnshowuserinfo.Click += new System.EventHandler(this.btnshowuserinfo_Click);
            // 
            // pnluserinfo
            // 
            this.pnluserinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnluserinfo.BackColor = System.Drawing.Color.AliceBlue;
            this.pnluserinfo.Controls.Add(this.txtage);
            this.pnluserinfo.Controls.Add(this.txtaddress);
            this.pnluserinfo.Controls.Add(this.txtEmail);
            this.pnluserinfo.Controls.Add(this.txtPass);
            this.pnluserinfo.Controls.Add(this.txtLastname);
            this.pnluserinfo.Controls.Add(this.txtfirstName);
            this.pnluserinfo.Controls.Add(this.LabEmail);
            this.pnluserinfo.Controls.Add(this.labAddress);
            this.pnluserinfo.Controls.Add(this.txtusername);
            this.pnluserinfo.Controls.Add(this.labpass);
            this.pnluserinfo.Controls.Add(this.labAge);
            this.pnluserinfo.Controls.Add(this.lablastname);
            this.pnluserinfo.Controls.Add(this.labfirstname);
            this.pnluserinfo.Controls.Add(this.labusername);
            this.pnluserinfo.HorizontalScrollbarBarColor = true;
            this.pnluserinfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnluserinfo.HorizontalScrollbarSize = 10;
            this.pnluserinfo.Location = new System.Drawing.Point(23, 92);
            this.pnluserinfo.Name = "pnluserinfo";
            this.pnluserinfo.Size = new System.Drawing.Size(813, 120);
            this.pnluserinfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.pnluserinfo.TabIndex = 23;
            this.pnluserinfo.UseCustomBackColor = true;
            this.pnluserinfo.UseStyleColors = true;
            this.pnluserinfo.VerticalScrollbarBarColor = true;
            this.pnluserinfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnluserinfo.VerticalScrollbarSize = 10;
            this.pnluserinfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnluserinfo_Paint);
            // 
            // txtage
            // 
            // 
            // 
            // 
            this.txtage.CustomButton.Image = null;
            this.txtage.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.txtage.CustomButton.Name = "";
            this.txtage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtage.CustomButton.TabIndex = 1;
            this.txtage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtage.CustomButton.UseSelectable = true;
            this.txtage.CustomButton.Visible = false;
            this.txtage.Lines = new string[0];
            this.txtage.Location = new System.Drawing.Point(711, 14);
            this.txtage.MaxLength = 32767;
            this.txtage.Name = "txtage";
            this.txtage.PasswordChar = '\0';
            this.txtage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtage.SelectedText = "";
            this.txtage.SelectionLength = 0;
            this.txtage.SelectionStart = 0;
            this.txtage.Size = new System.Drawing.Size(89, 23);
            this.txtage.TabIndex = 25;
            this.txtage.UseSelectable = true;
            this.txtage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtaddress
            // 
            // 
            // 
            // 
            this.txtaddress.CustomButton.Image = null;
            this.txtaddress.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txtaddress.CustomButton.Name = "";
            this.txtaddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtaddress.CustomButton.TabIndex = 1;
            this.txtaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtaddress.CustomButton.UseSelectable = true;
            this.txtaddress.CustomButton.Visible = false;
            this.txtaddress.Lines = new string[0];
            this.txtaddress.Location = new System.Drawing.Point(96, 89);
            this.txtaddress.MaxLength = 32767;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtaddress.SelectedText = "";
            this.txtaddress.SelectionLength = 0;
            this.txtaddress.SelectionStart = 0;
            this.txtaddress.Size = new System.Drawing.Size(704, 23);
            this.txtaddress.TabIndex = 26;
            this.txtaddress.UseSelectable = true;
            this.txtaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(303, 48);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(315, 23);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(96, 48);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(104, 23);
            this.txtPass.TabIndex = 28;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastname
            // 
            // 
            // 
            // 
            this.txtLastname.CustomButton.Image = null;
            this.txtLastname.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtLastname.CustomButton.Name = "";
            this.txtLastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastname.CustomButton.TabIndex = 1;
            this.txtLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastname.CustomButton.UseSelectable = true;
            this.txtLastname.CustomButton.Visible = false;
            this.txtLastname.Lines = new string[0];
            this.txtLastname.Location = new System.Drawing.Point(514, 14);
            this.txtLastname.MaxLength = 32767;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.Size = new System.Drawing.Size(104, 23);
            this.txtLastname.TabIndex = 29;
            this.txtLastname.UseSelectable = true;
            this.txtLastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastname.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // txtfirstName
            // 
            // 
            // 
            // 
            this.txtfirstName.CustomButton.Image = null;
            this.txtfirstName.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtfirstName.CustomButton.Name = "";
            this.txtfirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtfirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfirstName.CustomButton.TabIndex = 1;
            this.txtfirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfirstName.CustomButton.UseSelectable = true;
            this.txtfirstName.CustomButton.Visible = false;
            this.txtfirstName.Lines = new string[0];
            this.txtfirstName.Location = new System.Drawing.Point(303, 10);
            this.txtfirstName.MaxLength = 32767;
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.PasswordChar = '\0';
            this.txtfirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfirstName.SelectedText = "";
            this.txtfirstName.SelectionLength = 0;
            this.txtfirstName.SelectionStart = 0;
            this.txtfirstName.Size = new System.Drawing.Size(108, 23);
            this.txtfirstName.TabIndex = 30;
            this.txtfirstName.UseSelectable = true;
            this.txtfirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtfirstName.Click += new System.EventHandler(this.txtfirstName_Click);
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.CustomButton.Image = null;
            this.txtusername.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtusername.CustomButton.Name = "";
            this.txtusername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusername.CustomButton.TabIndex = 1;
            this.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusername.CustomButton.UseSelectable = true;
            this.txtusername.CustomButton.Visible = false;
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(96, 10);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.Size = new System.Drawing.Size(104, 23);
            this.txtusername.TabIndex = 31;
            this.txtusername.UseSelectable = true;
            this.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LabEmail
            // 
            this.LabEmail.AutoSize = true;
            this.LabEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabEmail.Location = new System.Drawing.Point(212, 52);
            this.LabEmail.Name = "LabEmail";
            this.LabEmail.Size = new System.Drawing.Size(49, 19);
            this.LabEmail.TabIndex = 8;
            this.LabEmail.Text = "Email:";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labAddress.Location = new System.Drawing.Point(13, 89);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(67, 19);
            this.labAddress.TabIndex = 7;
            this.labAddress.Text = "Address:";
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labpass.Location = new System.Drawing.Point(13, 48);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(77, 19);
            this.labpass.TabIndex = 6;
            this.labpass.Text = "Password:";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labAge.Location = new System.Drawing.Point(665, 18);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(40, 19);
            this.labAge.TabIndex = 5;
            this.labAge.Text = "Age:";
            // 
            // lablastname
            // 
            this.lablastname.AutoSize = true;
            this.lablastname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lablastname.Location = new System.Drawing.Point(425, 14);
            this.lablastname.Name = "lablastname";
            this.lablastname.Size = new System.Drawing.Size(83, 19);
            this.lablastname.TabIndex = 4;
            this.lablastname.Text = "Last Name:";
            // 
            // labfirstname
            // 
            this.labfirstname.AutoSize = true;
            this.labfirstname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labfirstname.Location = new System.Drawing.Point(212, 10);
            this.labfirstname.Name = "labfirstname";
            this.labfirstname.Size = new System.Drawing.Size(85, 19);
            this.labfirstname.TabIndex = 3;
            this.labfirstname.Text = "First Name:";
            // 
            // labusername
            // 
            this.labusername.AutoSize = true;
            this.labusername.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labusername.Location = new System.Drawing.Point(13, 10);
            this.labusername.Name = "labusername";
            this.labusername.Size = new System.Drawing.Size(77, 19);
            this.labusername.TabIndex = 2;
            this.labusername.Text = "UseName:";
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(467, 64);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(137, 25);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 24;
            this.metroButton2.Text = "Packages";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseMnemonic = false;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addTourDataGridViewTextBoxColumn,
            this.addHotelDataGridViewTextBoxColumn,
            this.addHotelCostDataGridViewTextBoxColumn,
            this.selecttransportDataGridViewTextBoxColumn,
            this.addTransportCostDataGridViewTextBoxColumn});
            this.metroGrid2.DataSource = this.addToursTableBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(23, 277);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(543, 162);
            this.metroGrid2.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(572, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Total Cost";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtplus
            // 
            // 
            // 
            // 
            this.txtplus.CustomButton.Image = null;
            this.txtplus.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.txtplus.CustomButton.Name = "";
            this.txtplus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtplus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtplus.CustomButton.TabIndex = 1;
            this.txtplus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtplus.CustomButton.UseSelectable = true;
            this.txtplus.CustomButton.Visible = false;
            this.txtplus.Lines = new string[0];
            this.txtplus.Location = new System.Drawing.Point(659, 382);
            this.txtplus.MaxLength = 32767;
            this.txtplus.Name = "txtplus";
            this.txtplus.PasswordChar = '\0';
            this.txtplus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtplus.SelectedText = "";
            this.txtplus.SelectionLength = 0;
            this.txtplus.SelectionStart = 0;
            this.txtplus.Size = new System.Drawing.Size(71, 23);
            this.txtplus.TabIndex = 26;
            this.txtplus.UseSelectable = true;
            this.txtplus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtplus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtplus.Click += new System.EventHandler(this.txtplus_Click);
            // 
            // addTourDataGridViewTextBoxColumn
            // 
            this.addTourDataGridViewTextBoxColumn.DataPropertyName = "AddTour";
            this.addTourDataGridViewTextBoxColumn.HeaderText = "Tour Name";
            this.addTourDataGridViewTextBoxColumn.Name = "addTourDataGridViewTextBoxColumn";
            this.addTourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addHotelDataGridViewTextBoxColumn
            // 
            this.addHotelDataGridViewTextBoxColumn.DataPropertyName = "AddHotel";
            this.addHotelDataGridViewTextBoxColumn.HeaderText = "Hotel Name";
            this.addHotelDataGridViewTextBoxColumn.Name = "addHotelDataGridViewTextBoxColumn";
            this.addHotelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addHotelCostDataGridViewTextBoxColumn
            // 
            this.addHotelCostDataGridViewTextBoxColumn.DataPropertyName = "AddHotelCost";
            this.addHotelCostDataGridViewTextBoxColumn.HeaderText = "Hotel Cost";
            this.addHotelCostDataGridViewTextBoxColumn.Name = "addHotelCostDataGridViewTextBoxColumn";
            this.addHotelCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selecttransportDataGridViewTextBoxColumn
            // 
            this.selecttransportDataGridViewTextBoxColumn.DataPropertyName = "Selecttransport";
            this.selecttransportDataGridViewTextBoxColumn.HeaderText = "Transport";
            this.selecttransportDataGridViewTextBoxColumn.Name = "selecttransportDataGridViewTextBoxColumn";
            this.selecttransportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addTransportCostDataGridViewTextBoxColumn
            // 
            this.addTransportCostDataGridViewTextBoxColumn.DataPropertyName = "AddTransportCost";
            this.addTransportCostDataGridViewTextBoxColumn.HeaderText = "Transport Cost";
            this.addTransportCostDataGridViewTextBoxColumn.Name = "addTransportCostDataGridViewTextBoxColumn";
            this.addTransportCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(871, 462);
            this.Controls.Add(this.txtplus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.pnluserinfo);
            this.Controls.Add(this.btnshowuserinfo);
            this.Controls.Add(this.metroButtonShowTours);
            this.Controls.Add(this.metroButtonConfirm);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btnShowTours);
            this.Controls.Add(this.btncustLogout);
            this.Name = "CustomerControl";
            this.Text = "CustomerControl";
            this.Load += new System.EventHandler(this.CustomerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custregTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet2)).EndInit();
            this.pnluserinfo.ResumeLayout(false);
            this.pnluserinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btncustLogout;
        private MetroFramework.Controls.MetroButton btnShowTours;
        private tavelagencyDataSet1 tavelagencyDataSet1;
        private System.Windows.Forms.BindingSource custregTableBindingSource;
        private tavelagencyDataSet1TableAdapters.custregTableTableAdapter custregTableTableAdapter;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private tavelagencyDataSet2 tavelagencyDataSet2;
        private System.Windows.Forms.BindingSource addToursTableBindingSource;
        private tavelagencyDataSet2TableAdapters.AddToursTableTableAdapter addToursTableTableAdapter;
        private MetroFramework.Controls.MetroButton metroButtonConfirm;
        private MetroFramework.Controls.MetroButton metroButtonShowTours;
        private MetroFramework.Controls.MetroButton btnshowuserinfo;
        private MetroFramework.Controls.MetroPanel pnluserinfo;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel labusername;
        private MetroFramework.Controls.MetroLabel labfirstname;
        private MetroFramework.Controls.MetroLabel lablastname;
        private MetroFramework.Controls.MetroLabel labAge;
        private MetroFramework.Controls.MetroLabel labpass;
        private MetroFramework.Controls.MetroLabel labAddress;
        private MetroFramework.Controls.MetroLabel LabEmail;
        private MetroFramework.Controls.MetroTextBox txtage;
        private MetroFramework.Controls.MetroTextBox txtaddress;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroTextBox txtfirstName;
        private MetroFramework.Controls.MetroTextBox txtusername;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtplus;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selecttransportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTransportCostDataGridViewTextBoxColumn;
    }
}