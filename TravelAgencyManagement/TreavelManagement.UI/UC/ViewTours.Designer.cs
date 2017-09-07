namespace TreavelManagement.UI.UC
{
    partial class ucviewTour
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGridviewtours = new MetroFramework.Controls.MetroGrid();
            this.addToursTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tavelagencyDataSet5 = new TreavelManagement.UI.tavelagencyDataSet5();
            this.addToursTableTableAdapter = new TreavelManagement.UI.tavelagencyDataSet5TableAdapters.AddToursTableTableAdapter();
            this.btnshowtours = new MetroFramework.Controls.MetroButton();
            this.addTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecttransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTransportCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridviewtours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(37, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(429, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Right Now These Exciting Packages are Available!! Grab Now!!";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroGridviewtours
            // 
            this.metroGridviewtours.AllowUserToAddRows = false;
            this.metroGridviewtours.AllowUserToDeleteRows = false;
            this.metroGridviewtours.AllowUserToResizeRows = false;
            this.metroGridviewtours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridviewtours.AutoGenerateColumns = false;
            this.metroGridviewtours.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridviewtours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridviewtours.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridviewtours.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridviewtours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridviewtours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridviewtours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addTourDataGridViewTextBoxColumn,
            this.addHotelDataGridViewTextBoxColumn,
            this.addHotelCostDataGridViewTextBoxColumn,
            this.addLocationDataGridViewTextBoxColumn,
            this.addDestinationDataGridViewTextBoxColumn,
            this.selecttransportDataGridViewTextBoxColumn,
            this.addTransportCostDataGridViewTextBoxColumn});
            this.metroGridviewtours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroGridviewtours.DataSource = this.addToursTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridviewtours.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridviewtours.EnableHeadersVisualStyles = false;
            this.metroGridviewtours.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridviewtours.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridviewtours.Location = new System.Drawing.Point(22, 78);
            this.metroGridviewtours.Name = "metroGridviewtours";
            this.metroGridviewtours.ReadOnly = true;
            this.metroGridviewtours.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridviewtours.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridviewtours.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridviewtours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridviewtours.Size = new System.Drawing.Size(734, 238);
            this.metroGridviewtours.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGridviewtours.TabIndex = 1;
            this.metroGridviewtours.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridviewtours.UseCustomBackColor = true;
            this.metroGridviewtours.UseCustomForeColor = true;
            this.metroGridviewtours.UseStyleColors = true;
            this.metroGridviewtours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridviewtours_CellContentClick);
            // 
            // addToursTableBindingSource
            // 
            this.addToursTableBindingSource.DataMember = "AddToursTable";
            this.addToursTableBindingSource.DataSource = this.tavelagencyDataSet5;
            // 
            // tavelagencyDataSet5
            // 
            this.tavelagencyDataSet5.DataSetName = "tavelagencyDataSet5";
            this.tavelagencyDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addToursTableTableAdapter
            // 
            this.addToursTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnshowtours
            // 
            this.btnshowtours.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnshowtours.DisplayFocus = true;
            this.btnshowtours.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnshowtours.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnshowtours.Highlight = true;
            this.btnshowtours.Location = new System.Drawing.Point(640, 322);
            this.btnshowtours.Name = "btnshowtours";
            this.btnshowtours.Size = new System.Drawing.Size(116, 23);
            this.btnshowtours.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnshowtours.TabIndex = 2;
            this.btnshowtours.Text = "Show";
            this.btnshowtours.UseCustomBackColor = true;
            this.btnshowtours.UseCustomForeColor = true;
            this.btnshowtours.UseSelectable = true;
            this.btnshowtours.UseStyleColors = true;
            this.btnshowtours.Click += new System.EventHandler(this.btnshowtours_Click);
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
            // addLocationDataGridViewTextBoxColumn
            // 
            this.addLocationDataGridViewTextBoxColumn.DataPropertyName = "AddLocation";
            this.addLocationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.addLocationDataGridViewTextBoxColumn.Name = "addLocationDataGridViewTextBoxColumn";
            this.addLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addDestinationDataGridViewTextBoxColumn
            // 
            this.addDestinationDataGridViewTextBoxColumn.DataPropertyName = "AddDestination";
            this.addDestinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.addDestinationDataGridViewTextBoxColumn.Name = "addDestinationDataGridViewTextBoxColumn";
            this.addDestinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selecttransportDataGridViewTextBoxColumn
            // 
            this.selecttransportDataGridViewTextBoxColumn.DataPropertyName = "Selecttransport";
            this.selecttransportDataGridViewTextBoxColumn.HeaderText = "Transport Type";
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
            // ucviewTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnshowtours);
            this.Controls.Add(this.metroGridviewtours);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ucviewTour";
            this.Size = new System.Drawing.Size(794, 373);
            this.Load += new System.EventHandler(this.ucviewTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridviewtours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGridviewtours;
        private System.Windows.Forms.BindingSource addToursTableBindingSource;
        private tavelagencyDataSet5 tavelagencyDataSet5;
        private tavelagencyDataSet5TableAdapters.AddToursTableTableAdapter addToursTableTableAdapter;
        private MetroFramework.Controls.MetroButton btnshowtours;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selecttransportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTransportCostDataGridViewTextBoxColumn;

    }
}
