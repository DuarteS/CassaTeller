using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaTeller
{
    public partial class AdminPage : Form
    {
        readonly KassaManagement KassaManagement;
        readonly WorkerManagment WorkerManagment;
        readonly KassaPage cassaPage;

        int mouseY;
        int mouseX;
        bool draggable;

        public AdminPage(KassaPage cassaPage)
        {
            InitializeComponent(); 
            KassaManagement = new KassaManagement();
            WorkerManagment = new WorkerManagment();
            this.cassaPage = cassaPage;
            FillKassaData();
            FillWorkerData();
        }

        private void FillKassaData()
        {
            gridData.Rows.Clear();
            KassaItem[] kassaItems = KassaManagement.getAllItems();
            foreach (KassaItem item in kassaItems)
            {
                Worker worker = WorkerManagment.GetWorkerByID(item.Worker);
                gridData.Rows.Add(item.DateTime,worker.FirstName, item.Total,item.Description);
            }


        }

        private void FillWorkerData()
        {
            

            cmbWorker.Items.Clear();
            foreach (Worker worker in WorkerManagment.GetWorkers())
            {
                cmbWorker.Items.Add(worker.ID + "- " + worker.FirstName);
            }
            cmbWorker.SelectedIndex = 0;

        }



        private void btnDifferance_Click(object sender, EventArgs e)
        {
            DateTime day1 = dtpAdmin1.Value;
            DateTime day2 = dtpAdmin2.Value;

            if (!KassaManagement.DateKassaCompleted(KassaManagement.GetDayItems(day1)))
            {
                lblErrorDay1.Text = "Error : geen Kassa opmaak van dezedag";
                return;
            }
            else
            {
                lblErrorDay1.Text = "";
            }

            if (!KassaManagement.DateKassaCompleted(KassaManagement.GetDayItems(day2)))
            {
                lblErrorDay2.Text = "Error : geen Kassa opmaak van dezedag";
                return;
            } else if (day1>day2) {
                lblErrorDay2.Text = "Datum 2 kan niet kleiner zijn als dag 1";
                return;
            }
            else
            {
                lblErrorDay2.Text = "";
            }

            tbDifferance.Text = KassaManagement.DayDifference(day1,day2).ToString();


        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            cassaPage.Visible = true;
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;

            WorkerManagment.AddWorker(firstName,lastName);

            tbFirstName.Text = "";
            tbLastName.Text = "";

            this.Close();


        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseY = Cursor.Position.Y - this.Top;
            mouseX = Cursor.Position.X - this.Left;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }

        private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int workerID = Convert.ToInt32(cmbWorker.Text.Split('-')[0]);
            Worker worker = WorkerManagment.GetWorkerByID(workerID);
            tbFirstNameUpdate.Text = worker.FirstName;
            tbLastNameUpdate.Text = worker.LastName;
        }

        private void btnWorkerUpdate_Click(object sender, EventArgs e)
        {
            if (tbFirstNameUpdate.Text == "")
            {
                MessageBox.Show("First Name cant be empty");
                return;
            }
            if (tbLastNameUpdate.Text == "")
            {
                MessageBox.Show("Last name cant be empty");
                return;
            }
            
            int workerID = Convert.ToInt32(cmbWorker.Text.Split('-')[0]);
            WorkerManagment.WorkerUpdateInfo(workerID, tbFirstNameUpdate.Text, tbLastNameUpdate.Text);
            FillWorkerData();

        }
    }
}
