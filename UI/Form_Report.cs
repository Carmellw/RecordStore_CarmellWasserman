using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordStore_CarmellWasserman.UI
{
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();
        }

        private void label_Order_Click(object sender, EventArgs e)
        {
            Form_OrderReport form_OrderReport = new Form_OrderReport();
            form_OrderReport.ShowDialog();
        }

        private void label_Stock_Click(object sender, EventArgs e)
        {
            Form_ProductReport form_ProductReport = new Form_ProductReport();
            form_ProductReport.ShowDialog();
        }

        private void label_Clients_Click(object sender, EventArgs e)
        {
            Form_ClientReport form_ClientReport = new Form_ClientReport();
            form_ClientReport.ShowDialog();
        }

        private void label_Employees_Click(object sender, EventArgs e)
        {
            Form_EmployeeReport form_EmployeeReport = new Form_EmployeeReport();
            form_EmployeeReport.ShowDialog();
        }
    }
}
