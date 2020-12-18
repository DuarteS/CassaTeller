using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassaTeller
{
    public partial class AdminPage : Form
    {
        readonly CassaManagement CassaManagement;
        readonly WorkerManagment WorkerManagment;
        readonly CassaPage cassaPage;
        public AdminPage(CassaPage cassaPage)
        {
            InitializeComponent(); 
            CassaManagement = new CassaManagement();
            WorkerManagment = new WorkerManagment();
            this.cassaPage = cassaPage;
        }

        private void btnDifferance_Click(object sender, EventArgs e)
        {
            DateTime day1 = dtpAdmin1.Value;
            DateTime day2 = dtpAdmin2.Value;

            if (!CassaManagement.DateCassaCompleted(CassaManagement.GetDayItems(day1)))
            {
                lblErrorDay1.Text = "Error : geen Cassa opmaak van dezedag";
                return;
            }
            else
            {
                lblErrorDay1.Text = "";
            }

            if (!CassaManagement.DateCassaCompleted(CassaManagement.GetDayItems(day2)))
            {
                lblErrorDay2.Text = "Error : geen Cassa opmaak van dezedag";
                return;
            } else if (day1>day2) {
                lblErrorDay2.Text = "Datum 2 kan niet kleiner zijn als dag 1";
                return;
            }
            else
            {
                lblErrorDay2.Text = "";
            }

            tbDifferance.Text = CassaManagement.DayDifference(day1,day2).ToString();


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

        }
    }
}
