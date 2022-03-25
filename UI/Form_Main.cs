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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void label_Order_Click(object sender, EventArgs e)
        {
            Form_Order form_Order = new Form_Order();
            form_Order.ShowDialog();

        }

        private void label_Clients_Click(object sender, EventArgs e)
        {
            Form_Client form_Client = new Form_Client();
            form_Client.ShowDialog();
        }

        private void label_Shifts_Click(object sender, EventArgs e)
        {
            Form_Shift form_Shift = new Form_Shift();
            form_Shift.ShowDialog();
        }

        private void label_Stock_Click(object sender, EventArgs e)
        {
            Form_Product form_Product = new Form_Product();
            form_Product.ShowDialog();
        }
    }
}
