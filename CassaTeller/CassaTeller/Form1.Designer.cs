namespace CassaTeller
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbAfromen = new System.Windows.Forms.RadioButton();
            this.rbBon = new System.Windows.Forms.RadioButton();
            this.rbCassa = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCassa = new System.Windows.Forms.TabPage();
            this.num500euro = new System.Windows.Forms.NumericUpDown();
            this.num200euro = new System.Windows.Forms.NumericUpDown();
            this.num100euro = new System.Windows.Forms.NumericUpDown();
            this.num50euro = new System.Windows.Forms.NumericUpDown();
            this.num20euro = new System.Windows.Forms.NumericUpDown();
            this.num10euro = new System.Windows.Forms.NumericUpDown();
            this.num5euro = new System.Windows.Forms.NumericUpDown();
            this.num2euro = new System.Windows.Forms.NumericUpDown();
            this.num1euro = new System.Windows.Forms.NumericUpDown();
            this.num50cent = new System.Windows.Forms.NumericUpDown();
            this.num20cent = new System.Windows.Forms.NumericUpDown();
            this.num10cent = new System.Windows.Forms.NumericUpDown();
            this.num5cent = new System.Windows.Forms.NumericUpDown();
            this.num2cent = new System.Windows.Forms.NumericUpDown();
            this.num1cent = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBonAfromen = new System.Windows.Forms.TabPage();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.gbType.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCassa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num500euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num200euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num100euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num20euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num20cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1cent)).BeginInit();
            this.tabBonAfromen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tijd :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MedeWerker :";
            // 
            // cmbWorker
            // 
            this.cmbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(105, 142);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(121, 21);
            this.cmbWorker.TabIndex = 5;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbAfromen);
            this.gbType.Controls.Add(this.rbBon);
            this.gbType.Controls.Add(this.rbCassa);
            this.gbType.Location = new System.Drawing.Point(106, 204);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(121, 114);
            this.gbType.TabIndex = 6;
            this.gbType.TabStop = false;
            this.gbType.Text = "Soort Data";
            // 
            // rbAfromen
            // 
            this.rbAfromen.AutoSize = true;
            this.rbAfromen.Location = new System.Drawing.Point(16, 75);
            this.rbAfromen.Name = "rbAfromen";
            this.rbAfromen.Size = new System.Drawing.Size(64, 17);
            this.rbAfromen.TabIndex = 9;
            this.rbAfromen.TabStop = true;
            this.rbAfromen.Text = "Afromen";
            this.rbAfromen.UseVisualStyleBackColor = true;
            this.rbAfromen.CheckedChanged += new System.EventHandler(this.rbAfromen_CheckedChanged);
            // 
            // rbBon
            // 
            this.rbBon.AutoSize = true;
            this.rbBon.Location = new System.Drawing.Point(16, 52);
            this.rbBon.Name = "rbBon";
            this.rbBon.Size = new System.Drawing.Size(44, 17);
            this.rbBon.TabIndex = 8;
            this.rbBon.TabStop = true;
            this.rbBon.Text = "Bon";
            this.rbBon.UseVisualStyleBackColor = true;
            this.rbBon.CheckedChanged += new System.EventHandler(this.rbBon_CheckedChanged);
            // 
            // rbCassa
            // 
            this.rbCassa.AutoSize = true;
            this.rbCassa.Location = new System.Drawing.Point(16, 29);
            this.rbCassa.Name = "rbCassa";
            this.rbCassa.Size = new System.Drawing.Size(54, 17);
            this.rbCassa.TabIndex = 7;
            this.rbCassa.TabStop = true;
            this.rbCassa.Text = "Cassa";
            this.rbCassa.UseVisualStyleBackColor = true;
            this.rbCassa.CheckedChanged += new System.EventHandler(this.rbCassa_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCassa);
            this.tabControl1.Controls.Add(this.tabBonAfromen);
            this.tabControl1.Location = new System.Drawing.Point(314, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 269);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabCassa
            // 
            this.tabCassa.Controls.Add(this.num500euro);
            this.tabCassa.Controls.Add(this.num200euro);
            this.tabCassa.Controls.Add(this.num100euro);
            this.tabCassa.Controls.Add(this.num50euro);
            this.tabCassa.Controls.Add(this.num20euro);
            this.tabCassa.Controls.Add(this.num10euro);
            this.tabCassa.Controls.Add(this.num5euro);
            this.tabCassa.Controls.Add(this.num2euro);
            this.tabCassa.Controls.Add(this.num1euro);
            this.tabCassa.Controls.Add(this.num50cent);
            this.tabCassa.Controls.Add(this.num20cent);
            this.tabCassa.Controls.Add(this.num10cent);
            this.tabCassa.Controls.Add(this.num5cent);
            this.tabCassa.Controls.Add(this.num2cent);
            this.tabCassa.Controls.Add(this.num1cent);
            this.tabCassa.Controls.Add(this.label12);
            this.tabCassa.Controls.Add(this.label13);
            this.tabCassa.Controls.Add(this.label14);
            this.tabCassa.Controls.Add(this.label15);
            this.tabCassa.Controls.Add(this.label16);
            this.tabCassa.Controls.Add(this.label17);
            this.tabCassa.Controls.Add(this.label18);
            this.tabCassa.Controls.Add(this.label8);
            this.tabCassa.Controls.Add(this.label9);
            this.tabCassa.Controls.Add(this.label10);
            this.tabCassa.Controls.Add(this.label11);
            this.tabCassa.Controls.Add(this.label6);
            this.tabCassa.Controls.Add(this.label7);
            this.tabCassa.Controls.Add(this.label5);
            this.tabCassa.Controls.Add(this.label4);
            this.tabCassa.Location = new System.Drawing.Point(4, 22);
            this.tabCassa.Name = "tabCassa";
            this.tabCassa.Padding = new System.Windows.Forms.Padding(3);
            this.tabCassa.Size = new System.Drawing.Size(445, 243);
            this.tabCassa.TabIndex = 0;
            this.tabCassa.Text = "Cassa";
            this.tabCassa.UseVisualStyleBackColor = true;
            // 
            // num500euro
            // 
            this.num500euro.Location = new System.Drawing.Point(263, 177);
            this.num500euro.Name = "num500euro";
            this.num500euro.Size = new System.Drawing.Size(120, 20);
            this.num500euro.TabIndex = 29;
            // 
            // num200euro
            // 
            this.num200euro.Location = new System.Drawing.Point(263, 151);
            this.num200euro.Name = "num200euro";
            this.num200euro.Size = new System.Drawing.Size(120, 20);
            this.num200euro.TabIndex = 28;
            // 
            // num100euro
            // 
            this.num100euro.Location = new System.Drawing.Point(263, 125);
            this.num100euro.Name = "num100euro";
            this.num100euro.Size = new System.Drawing.Size(120, 20);
            this.num100euro.TabIndex = 27;
            // 
            // num50euro
            // 
            this.num50euro.Location = new System.Drawing.Point(263, 99);
            this.num50euro.Name = "num50euro";
            this.num50euro.Size = new System.Drawing.Size(120, 20);
            this.num50euro.TabIndex = 26;
            // 
            // num20euro
            // 
            this.num20euro.Location = new System.Drawing.Point(263, 74);
            this.num20euro.Name = "num20euro";
            this.num20euro.Size = new System.Drawing.Size(120, 20);
            this.num20euro.TabIndex = 25;
            // 
            // num10euro
            // 
            this.num10euro.Location = new System.Drawing.Point(263, 49);
            this.num10euro.Name = "num10euro";
            this.num10euro.Size = new System.Drawing.Size(120, 20);
            this.num10euro.TabIndex = 24;
            // 
            // num5euro
            // 
            this.num5euro.Location = new System.Drawing.Point(263, 23);
            this.num5euro.Name = "num5euro";
            this.num5euro.Size = new System.Drawing.Size(120, 20);
            this.num5euro.TabIndex = 23;
            // 
            // num2euro
            // 
            this.num2euro.Location = new System.Drawing.Point(64, 201);
            this.num2euro.Name = "num2euro";
            this.num2euro.Size = new System.Drawing.Size(120, 20);
            this.num2euro.TabIndex = 22;
            // 
            // num1euro
            // 
            this.num1euro.Location = new System.Drawing.Point(64, 175);
            this.num1euro.Name = "num1euro";
            this.num1euro.Size = new System.Drawing.Size(120, 20);
            this.num1euro.TabIndex = 21;
            // 
            // num50cent
            // 
            this.num50cent.Location = new System.Drawing.Point(64, 149);
            this.num50cent.Name = "num50cent";
            this.num50cent.Size = new System.Drawing.Size(120, 20);
            this.num50cent.TabIndex = 20;
            // 
            // num20cent
            // 
            this.num20cent.Location = new System.Drawing.Point(64, 123);
            this.num20cent.Name = "num20cent";
            this.num20cent.Size = new System.Drawing.Size(120, 20);
            this.num20cent.TabIndex = 19;
            // 
            // num10cent
            // 
            this.num10cent.Location = new System.Drawing.Point(64, 100);
            this.num10cent.Name = "num10cent";
            this.num10cent.Size = new System.Drawing.Size(120, 20);
            this.num10cent.TabIndex = 18;
            // 
            // num5cent
            // 
            this.num5cent.Location = new System.Drawing.Point(64, 74);
            this.num5cent.Name = "num5cent";
            this.num5cent.Size = new System.Drawing.Size(120, 20);
            this.num5cent.TabIndex = 17;
            // 
            // num2cent
            // 
            this.num2cent.Location = new System.Drawing.Point(64, 49);
            this.num2cent.Name = "num2cent";
            this.num2cent.Size = new System.Drawing.Size(120, 20);
            this.num2cent.TabIndex = 16;
            // 
            // num1cent
            // 
            this.num1cent.Location = new System.Drawing.Point(64, 23);
            this.num1cent.Name = "num1cent";
            this.num1cent.Size = new System.Drawing.Size(120, 20);
            this.num1cent.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "€ 500";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "€ 200";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "€ 100";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(219, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "€ 50";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(219, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "€ 20";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(219, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "€ 10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(219, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "€ 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "€ 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "€ 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "€ 0,50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "€ 0,20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "€ 0,10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "€ 0,05";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "€ 0,02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "€ 0,01";
            // 
            // tabBonAfromen
            // 
            this.tabBonAfromen.Controls.Add(this.tbDesc);
            this.tabBonAfromen.Controls.Add(this.label20);
            this.tabBonAfromen.Controls.Add(this.tbTotal);
            this.tabBonAfromen.Controls.Add(this.label19);
            this.tabBonAfromen.Location = new System.Drawing.Point(4, 22);
            this.tabBonAfromen.Name = "tabBonAfromen";
            this.tabBonAfromen.Padding = new System.Windows.Forms.Padding(3);
            this.tabBonAfromen.Size = new System.Drawing.Size(445, 243);
            this.tabBonAfromen.TabIndex = 1;
            this.tabBonAfromen.Text = "Bon/Afromen";
            this.tabBonAfromen.UseVisualStyleBackColor = true;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(674, 339);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(89, 35);
            this.btnOpslaan.TabIndex = 8;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(105, 49);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Enabled = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(105, 90);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(122, 20);
            this.dtpTime.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Totaal :";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(91, 22);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(94, 20);
            this.tbTotal.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Opmerking :";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(91, 62);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(159, 63);
            this.tbDesc.TabIndex = 3;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(27, 339);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(89, 35);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCassa.ResumeLayout(false);
            this.tabCassa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num500euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num200euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num100euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num20euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num20cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1cent)).EndInit();
            this.tabBonAfromen.ResumeLayout(false);
            this.tabBonAfromen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbAfromen;
        private System.Windows.Forms.RadioButton rbBon;
        private System.Windows.Forms.RadioButton rbCassa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCassa;
        private System.Windows.Forms.TabPage tabBonAfromen;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num500euro;
        private System.Windows.Forms.NumericUpDown num200euro;
        private System.Windows.Forms.NumericUpDown num100euro;
        private System.Windows.Forms.NumericUpDown num50euro;
        private System.Windows.Forms.NumericUpDown num20euro;
        private System.Windows.Forms.NumericUpDown num10euro;
        private System.Windows.Forms.NumericUpDown num5euro;
        private System.Windows.Forms.NumericUpDown num2euro;
        private System.Windows.Forms.NumericUpDown num1euro;
        private System.Windows.Forms.NumericUpDown num50cent;
        private System.Windows.Forms.NumericUpDown num20cent;
        private System.Windows.Forms.NumericUpDown num10cent;
        private System.Windows.Forms.NumericUpDown num5cent;
        private System.Windows.Forms.NumericUpDown num2cent;
        private System.Windows.Forms.NumericUpDown num1cent;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnAdmin;
    }
}

