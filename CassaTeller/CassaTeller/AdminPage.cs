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
        public AdminPage(KassaPage cassaPage)
        {
            InitializeComponent(); 
            KassaManagement = new KassaManagement();
            WorkerManagment = new WorkerManagment();
            this.cassaPage = cassaPage;
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


        }
    }
}
