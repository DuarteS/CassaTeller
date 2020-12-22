
namespace KassaTeller
{
    partial class AdminPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKassaInfo = new System.Windows.Forms.TabPage();
            this.gridData = new MetroFramework.Controls.MetroGrid();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totaal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opmerking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDifferance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorDay2 = new System.Windows.Forms.Label();
            this.lblErrorDay1 = new System.Windows.Forms.Label();
            this.btnDifferance = new System.Windows.Forms.Button();
            this.dtpAdmin2 = new System.Windows.Forms.DateTimePicker();
            this.dtpAdmin1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabWorkers = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWorkerUpdate = new System.Windows.Forms.Button();
            this.tbLastNameUpdate = new System.Windows.Forms.TextBox();
            this.tbFirstNameUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbWorker = new MetroFramework.Controls.MetroComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabKassaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.tabWorkers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKassaInfo);
            this.tabControl1.Controls.Add(this.tabWorkers);
            this.tabControl1.Location = new System.Drawing.Point(20, 95);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKassaInfo
            // 
            this.tabKassaInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabKassaInfo.Controls.Add(this.gridData);
            this.tabKassaInfo.Controls.Add(this.tbDifferance);
            this.tabKassaInfo.Controls.Add(this.label3);
            this.tabKassaInfo.Controls.Add(this.lblErrorDay2);
            this.tabKassaInfo.Controls.Add(this.lblErrorDay1);
            this.tabKassaInfo.Controls.Add(this.btnDifferance);
            this.tabKassaInfo.Controls.Add(this.dtpAdmin2);
            this.tabKassaInfo.Controls.Add(this.dtpAdmin1);
            this.tabKassaInfo.Controls.Add(this.label2);
            this.tabKassaInfo.Controls.Add(this.label1);
            this.tabKassaInfo.Location = new System.Drawing.Point(4, 30);
            this.tabKassaInfo.Margin = new System.Windows.Forms.Padding(5);
            this.tabKassaInfo.Name = "tabKassaInfo";
            this.tabKassaInfo.Padding = new System.Windows.Forms.Padding(5);
            this.tabKassaInfo.Size = new System.Drawing.Size(954, 578);
            this.tabKassaInfo.TabIndex = 0;
            this.tabKassaInfo.Text = "Kassa Info";
            // 
            // gridData
            // 
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Naam,
            this.Totaal,
            this.Opmerking});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.Location = new System.Drawing.Point(59, 248);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(884, 294);
            this.gridData.TabIndex = 9;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.Width = 250;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.Name = "Naam";
            this.Naam.Width = 200;
            // 
            // Totaal
            // 
            this.Totaal.HeaderText = "Totaal";
            this.Totaal.Name = "Totaal";
            this.Totaal.Width = 150;
            // 
            // Opmerking
            // 
            this.Opmerking.HeaderText = "Opmerking";
            this.Opmerking.Name = "Opmerking";
            this.Opmerking.Width = 250;
            // 
            // tbDifferance
            // 
            this.tbDifferance.Enabled = false;
            this.tbDifferance.Location = new System.Drawing.Point(204, 202);
            this.tbDifferance.Margin = new System.Windows.Forms.Padding(5);
            this.tbDifferance.Name = "tbDifferance";
            this.tbDifferance.Size = new System.Drawing.Size(312, 27);
            this.tbDifferance.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verschil :";
            // 
            // lblErrorDay2
            // 
            this.lblErrorDay2.AutoSize = true;
            this.lblErrorDay2.Location = new System.Drawing.Point(562, 112);
            this.lblErrorDay2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblErrorDay2.Name = "lblErrorDay2";
            this.lblErrorDay2.Size = new System.Drawing.Size(0, 21);
            this.lblErrorDay2.TabIndex = 6;
            // 
            // lblErrorDay1
            // 
            this.lblErrorDay1.AutoSize = true;
            this.lblErrorDay1.Location = new System.Drawing.Point(562, 76);
            this.lblErrorDay1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblErrorDay1.Name = "lblErrorDay1";
            this.lblErrorDay1.Size = new System.Drawing.Size(0, 21);
            this.lblErrorDay1.TabIndex = 5;
            // 
            // btnDifferance
            // 
            this.btnDifferance.Location = new System.Drawing.Point(379, 149);
            this.btnDifferance.Margin = new System.Windows.Forms.Padding(5);
            this.btnDifferance.Name = "btnDifferance";
            this.btnDifferance.Size = new System.Drawing.Size(135, 31);
            this.btnDifferance.TabIndex = 4;
            this.btnDifferance.Text = "Verschil";
            this.btnDifferance.UseVisualStyleBackColor = true;
            this.btnDifferance.Click += new System.EventHandler(this.btnDifferance_Click);
            // 
            // dtpAdmin2
            // 
            this.dtpAdmin2.Location = new System.Drawing.Point(202, 112);
            this.dtpAdmin2.Margin = new System.Windows.Forms.Padding(5);
            this.dtpAdmin2.Name = "dtpAdmin2";
            this.dtpAdmin2.Size = new System.Drawing.Size(312, 27);
            this.dtpAdmin2.TabIndex = 3;
            // 
            // dtpAdmin1
            // 
            this.dtpAdmin1.Location = new System.Drawing.Point(202, 66);
            this.dtpAdmin1.Margin = new System.Windows.Forms.Padding(5);
            this.dtpAdmin1.Name = "dtpAdmin1";
            this.dtpAdmin1.Size = new System.Drawing.Size(312, 27);
            this.dtpAdmin1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tweede Dag :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eerste Dag :";
            // 
            // tabWorkers
            // 
            this.tabWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabWorkers.Controls.Add(this.groupBox2);
            this.tabWorkers.Controls.Add(this.groupBox1);
            this.tabWorkers.Location = new System.Drawing.Point(4, 30);
            this.tabWorkers.Margin = new System.Windows.Forms.Padding(5);
            this.tabWorkers.Name = "tabWorkers";
            this.tabWorkers.Padding = new System.Windows.Forms.Padding(5);
            this.tabWorkers.Size = new System.Drawing.Size(954, 578);
            this.tabWorkers.TabIndex = 1;
            this.tabWorkers.Text = "Medewerkers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddWorker);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(60, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(372, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nieuw Medewerker";
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(172, 172);
            this.btnAddWorker.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(167, 53);
            this.btnAddWorker.TabIndex = 5;
            this.btnAddWorker.Text = "Toevoegen";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(175, 108);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(5);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(164, 27);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(175, 45);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(164, 27);
            this.tbFirstName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Achter Naam :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Naam :";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label9);
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.btnCloseForm);
            this.pnlTop.Controls.Add(this.panel4);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1002, 88);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(179)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(864, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "Logout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(179)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(178, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(926, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(35, 35);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.Location = new System.Drawing.Point(967, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(35, 35);
            this.btnCloseForm.TabIndex = 6;
            this.btnCloseForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 88);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KassaTeller.Properties.Resources.logo_465x320;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbWorker);
            this.groupBox2.Controls.Add(this.btnWorkerUpdate);
            this.groupBox2.Controls.Add(this.tbLastNameUpdate);
            this.groupBox2.Controls.Add(this.tbFirstNameUpdate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(513, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(372, 349);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medewerker Update";
            // 
            // btnWorkerUpdate
            // 
            this.btnWorkerUpdate.Location = new System.Drawing.Point(175, 245);
            this.btnWorkerUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnWorkerUpdate.Name = "btnWorkerUpdate";
            this.btnWorkerUpdate.Size = new System.Drawing.Size(167, 53);
            this.btnWorkerUpdate.TabIndex = 5;
            this.btnWorkerUpdate.Text = "Update";
            this.btnWorkerUpdate.UseVisualStyleBackColor = true;
            this.btnWorkerUpdate.Click += new System.EventHandler(this.btnWorkerUpdate_Click);
            // 
            // tbLastNameUpdate
            // 
            this.tbLastNameUpdate.Location = new System.Drawing.Point(175, 185);
            this.tbLastNameUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.tbLastNameUpdate.Name = "tbLastNameUpdate";
            this.tbLastNameUpdate.Size = new System.Drawing.Size(164, 27);
            this.tbLastNameUpdate.TabIndex = 4;
            // 
            // tbFirstNameUpdate
            // 
            this.tbFirstNameUpdate.Location = new System.Drawing.Point(175, 122);
            this.tbFirstNameUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.tbFirstNameUpdate.Name = "tbFirstNameUpdate";
            this.tbFirstNameUpdate.Size = new System.Drawing.Size(164, 27);
            this.tbFirstNameUpdate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Achter Naam :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Naam :";
            // 
            // cmbWorker
            // 
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.ItemHeight = 23;
            this.cmbWorker.Location = new System.Drawing.Point(175, 49);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(164, 29);
            this.cmbWorker.TabIndex = 16;
            this.cmbWorker.UseSelectable = true;
            this.cmbWorker.SelectedIndexChanged += new System.EventHandler(this.cmbWorker_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "MedeWerker :";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1002, 727);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabKassaInfo.ResumeLayout(false);
            this.tabKassaInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.tabWorkers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKassaInfo;
        private System.Windows.Forms.TabPage tabWorkers;
        private System.Windows.Forms.Label lblErrorDay2;
        private System.Windows.Forms.Label lblErrorDay1;
        private System.Windows.Forms.Button btnDifferance;
        private System.Windows.Forms.DateTimePicker dtpAdmin2;
        private System.Windows.Forms.DateTimePicker dtpAdmin1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDifferance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid gridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totaal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opmerking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWorkerUpdate;
        private System.Windows.Forms.TextBox tbLastNameUpdate;
        private System.Windows.Forms.TextBox tbFirstNameUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroComboBox cmbWorker;
        private System.Windows.Forms.Label label10;
    }
}