using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassaTeller
{
    public partial class Form1 : Form
    {
        
        const decimal cent1 = 0.01m;
        const decimal cent2 = 0.02m;
        const decimal cent5 = 0.05m;
        const decimal cent10 = 0.10m;
        const decimal cent20 = 0.20m;
        const decimal cent50 = 0.50m;
        const decimal euro1 = 1;
        const decimal euro2 = 2;
        const decimal euro5 = 5;
        const decimal euro10 = 10;
        const decimal euro20 = 20;
        const decimal euro50 = 50;
        const decimal euro100 = 100;
        const decimal euro200 = 200;
        const decimal euro500 = 500;

        readonly CassaManagement CassaManagement;
        readonly WorkerManagment WorkerManagment;
        public Form1()
        {
            InitializeComponent();
            CassaManagement = new CassaManagement();
            WorkerManagment = new WorkerManagment();
            FormFill();


        }

        private void FormFill()
        {
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;
            rbCassa.Checked = true;

            

            cmbWorker.Items.Clear();
            foreach (Worker worker in WorkerManagment.GetWorkers())
            {
                cmbWorker.Items.Add(worker.ID+"- "+worker.FirstName + " " + worker.LastName);
            }
            cmbWorker.SelectedIndex = 0;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            

            string Desc = "";

            if (rbCassa.Checked)
            {
                Desc += "Dag Cassa";

                total += cent1 * num1cent.Value;
                total += cent2 * num2cent.Value;
                total += cent5 * num5cent.Value;
                total += cent10 * num10cent.Value;
                total += cent20 * num20cent.Value;
                total += cent50 * num50cent.Value;
                total += euro1 * num1euro.Value;
                total += euro2 * num2euro.Value;
                total += euro5 * num5euro.Value;
                total += euro10 * num10euro.Value;
                total += euro20 * num20euro.Value;
                total += euro50 * num50euro.Value;
                total += euro100 * num100euro.Value;
                total += euro200 * num200euro.Value;
                total += euro500 * num500euro.Value;

            } else if (rbAfromen.Checked)
            {
                Desc += "Afromen";
                total = decimal.Parse(tbTotal.Text.Replace(".",","));
                Desc += tbDesc.Text;
            } else if (rbBon.Checked)
            {
                Desc += "Bon";
                total = decimal.Parse(tbTotal.Text.Replace(".", ","));
                Desc += tbDesc.Text;
            }

            CassaItem cassaItem = new CassaItem(DateTime.Now,Convert.ToInt32(cmbWorker.Text.Split('-')[0]),total,rbCassa.Checked,Desc);
            CassaManagement.CassaAddItem(cassaItem);
        }

        private void rbCassa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCassa.Checked)
            {
                tabControl1.SelectedIndex = 0;
            }
           
        }

        private void rbBon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBon.Checked)
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void rbAfromen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAfromen.Checked)
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                rbBon.Checked = true;
            }
            if (tabControl1.SelectedIndex == 0)
            {
                rbCassa.Checked = true;
            }
        }
    }
}
