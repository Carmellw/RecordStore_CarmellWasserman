using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecordStore_CarmellWasserman.BL;

namespace RecordStore_CarmellWasserman.UI
{
    public partial class Form_Password : Form
    {
        public Form_Password()
        {
            InitializeComponent();
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();
            if(employeeArr.IsLogIn(textBox_Username.Text, textBox_Password.Text))
            {
                textBox_Username.Text = "";
                textBox_Password.Text = "";
                Form_Main form_Main = new Form_Main();
                form_Main.ShowDialog();
                
            }

            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }
    }
}
