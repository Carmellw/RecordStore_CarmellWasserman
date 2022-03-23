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
    }
}
