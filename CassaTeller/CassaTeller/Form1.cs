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
        CassaManagement CassaManagement;
        public Form1()
        {
            InitializeComponent();
            CassaManagement = new CassaManagement();


        }
    }
}
