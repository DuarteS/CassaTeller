
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKassaInfo = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabKassaInfo.SuspendLayout();
            this.tabWorkers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKassaInfo);
            this.tabControl1.Controls.Add(this.tabWorkers);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKassaInfo
            // 
            this.tabKassaInfo.Controls.Add(this.tbDifferance);
            this.tabKassaInfo.Controls.Add(this.label3);
            this.tabKassaInfo.Controls.Add(this.lblErrorDay2);
            this.tabKassaInfo.Controls.Add(this.lblErrorDay1);
            this.tabKassaInfo.Controls.Add(this.btnDifferance);
            this.tabKassaInfo.Controls.Add(this.dtpAdmin2);
            this.tabKassaInfo.Controls.Add(this.dtpAdmin1);
            this.tabKassaInfo.Controls.Add(this.label2);
            this.tabKassaInfo.Controls.Add(this.label1);
            this.tabKassaInfo.Location = new System.Drawing.Point(4, 22);
            this.tabKassaInfo.Name = "tabKassaInfo";
            this.tabKassaInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabKassaInfo.Size = new System.Drawing.Size(768, 400);
            this.tabKassaInfo.TabIndex = 0;
            this.tabKassaInfo.Text = "Kassa Info";
            this.tabKassaInfo.UseVisualStyleBackColor = true;
            // 
            // tbDifferance
            // 
            this.tbDifferance.Enabled = false;
            this.tbDifferance.Location = new System.Drawing.Point(121, 200);
            this.tbDifferance.Name = "tbDifferance";
            this.tbDifferance.Size = new System.Drawing.Size(189, 20);
            this.tbDifferance.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verschil :";
            // 
            // lblErrorDay2
            // 
            this.lblErrorDay2.AutoSize = true;
            this.lblErrorDay2.Location = new System.Drawing.Point(337, 98);
            this.lblErrorDay2.Name = "lblErrorDay2";
            this.lblErrorDay2.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDay2.TabIndex = 6;
            // 
            // lblErrorDay1
            // 
            this.lblErrorDay1.AutoSize = true;
            this.lblErrorDay1.Location = new System.Drawing.Point(337, 47);
            this.lblErrorDay1.Name = "lblErrorDay1";
            this.lblErrorDay1.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDay1.TabIndex = 5;
            // 
            // btnDifferance
            // 
            this.btnDifferance.Location = new System.Drawing.Point(229, 137);
            this.btnDifferance.Name = "btnDifferance";
            this.btnDifferance.Size = new System.Drawing.Size(81, 39);
            this.btnDifferance.TabIndex = 4;
            this.btnDifferance.Text = "Verschil";
            this.btnDifferance.UseVisualStyleBackColor = true;
            this.btnDifferance.Click += new System.EventHandler(this.btnDifferance_Click);
            // 
            // dtpAdmin2
            // 
            this.dtpAdmin2.Location = new System.Drawing.Point(121, 91);
            this.dtpAdmin2.Name = "dtpAdmin2";
            this.dtpAdmin2.Size = new System.Drawing.Size(189, 20);
            this.dtpAdmin2.TabIndex = 3;
            // 
            // dtpAdmin1
            // 
            this.dtpAdmin1.Location = new System.Drawing.Point(121, 41);
            this.dtpAdmin1.Name = "dtpAdmin1";
            this.dtpAdmin1.Size = new System.Drawing.Size(189, 20);
            this.dtpAdmin1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tweede Dag :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eerste Dag :";
            // 
            // tabWorkers
            // 
            this.tabWorkers.Controls.Add(this.groupBox1);
            this.tabWorkers.Location = new System.Drawing.Point(4, 22);
            this.tabWorkers.Name = "tabWorkers";
            this.tabWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkers.Size = new System.Drawing.Size(768, 400);
            this.tabWorkers.TabIndex = 1;
            this.tabWorkers.Text = "Medewerkers";
            this.tabWorkers.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddWorker);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(36, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nieuw Medewerker";
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(106, 247);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(100, 33);
            this.btnAddWorker.TabIndex = 5;
            this.btnAddWorker.Text = "Toevoegen";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(106, 79);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(106, 40);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Achter Naam :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Naam :";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabKassaInfo.ResumeLayout(false);
            this.tabKassaInfo.PerformLayout();
            this.tabWorkers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}