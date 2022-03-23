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

namespace RecordStore_CarmellWasserman
{
    public partial class Form_Employee : Form
    {
        public Form_Employee(Employee employee = null)
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            EmployeeArrToForm();
        }

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private void textBox_Heb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.KeyChar = char.MinValue;
            }





        }

        private void textBox_All_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' &&!char.IsDigit(e.KeyChar) && char.IsSymbol(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
            }





        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading |
                MessageBoxOptions.RightAlign);
            }
            else
            {
                MessageBox.Show("All Fields OK");
                Employee employee = FormToEmployee();

                if (label_Id.Text == "0")
                {
                    employee.Insert();
                    MessageBox.Show("Saved");
                }

                else
                {
                    employee.Update();
                    MessageBox.Show("Updated");
                }
                EmployeeArrToForm();

            }
        }

        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            //בדיקת שם פרטי //

            if (textBox_FirstName.Text.Length < 2)
            {
                flag = false;
                label_FirstName.ForeColor = Color.Red;
            }
            else
                label_FirstName.ForeColor = Color.Black;

            //בדיקת שם משפחה //

            if (textBox_LastName.Text.Length < 2)
            {
                flag = false;
                label_LastName.ForeColor = Color.Red;
            }
            else
                label_LastName.ForeColor = Color.Black;

            //בדיקת מספר טלפון //

            if (textBox_PhoneNumber.Text.Length != 10)
            {
                flag = false;
                label_PhoneNumber.ForeColor = Color.Red;
            }
            else
                label_PhoneNumber.ForeColor = Color.Black;


            //בדיקת מיקוד //

            if (textBox_HourlyWage.Text == "")
            {
                flag = false;
                label_HourlyWage.ForeColor = Color.Red;
            }
            else
            {
                label_HourlyWage.ForeColor = Color.Black;
            }

            if (textBox_Email.Text.Length <4)
            {
                flag = false;
                label_HourlyWage.ForeColor = Color.Red;
            }
            else
            {
                label_HourlyWage.ForeColor = Color.Black;
            }

            if (textBox_Password.Text == "")
            {
                flag = false;
                label_HourlyWage.ForeColor = Color.Red;
            }
            else
            {
                label_HourlyWage.ForeColor = Color.Black;
            }

            if (textBox_Username.Text == "")
            {
                flag = false;
                label_HourlyWage.ForeColor = Color.Red;
            }
            else
            {
                label_HourlyWage.ForeColor = Color.Black;
            }




            return flag;
        }

        private Employee FormToEmployee()
        {
            Employee employee = new Employee();
            employee.FirstName = textBox_FirstName.Text;
            employee.LastName = textBox_LastName.Text;
            employee.Id = int.Parse(label_Id.Text);
            //בדיקה האם יש ערך בשדה להמרה


            employee.HourlyWage = int.Parse(textBox_HourlyWage.Text);
            
            employee.PhoneNumber = int.Parse(textBox_PhoneNumber.Text);
            employee.Email = textBox_Email.Text;
            employee.Username = textBox_Username.Text;
            employee.Password = textBox_Password.Text;

            return employee;
        }



        private void EmployeeArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();
            listBox_Employees.DataSource = employeeArr;
            listBox_Employees.ValueMember = "Id";
            listBox_Employees.DisplayMember = "";
        }


        private void EmployeeToForm(Employee employee)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס



            if (employee != null)
            {
                label_Id.Text = employee.Id.ToString();
                textBox_FirstName.Text = employee.FirstName;
                textBox_LastName.Text = employee.LastName;
                if (employee.PhoneNumber > 999999999)
                {
                    textBox_PhoneNumber.Text = employee.PhoneNumber.ToString();
                }
                else
                {
                    textBox_PhoneNumber.Text = "0" + employee.PhoneNumber.ToString();
                }
                textBox_HourlyWage.Text = employee.HourlyWage.ToString();
                textBox_Email.Text = employee.Email;
                textBox_Username.Text = employee.Username;
                textBox_Password.Text = employee.Password;

            }

            else
            {
                label_Id.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_PhoneNumber.Text = "";
                textBox_HourlyWage.Text = "";
                textBox_Email.Text = "";
                textBox_Username.Text = "";
                textBox_Password.Text = "";
            }
        }

        private void listBox_Employees_DoubleClick(object sender, EventArgs e)
        {
            Employee employee = listBox_Employees.SelectedItem as Employee;
            EmployeeToForm(employee);
        }

        private void clear_Click(object sender, EventArgs e)
        {

            label_Id.Text = "0";
            textBox_FirstName.Text = "";
            textBox_LastName.Text = "";
            textBox_PhoneNumber.Text = "";
            textBox_HourlyWage.Text = "";
            textBox_Email.Text = "";
            textBox_Username.Text = "";
            textBox_Password.Text = "";
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            textBox_FirstNameFilter.Text = "";
            textBox_LastNameFilter.Text = "";
            textBox_PhoneNumberFilter.Text = "";
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            Employee employee = FormToEmployee();
            if (employee.Id == 0)
            {
                MessageBox.Show("You need to choose a employee");
            }
            else

            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (employee.Delete())
                    {
                        MessageBox.Show("Deleted");
                    }

                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                    EmployeeToForm(null);
                    EmployeeArrToForm();
                }
            }
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_IdFilter.Text != "")
                id = int.Parse(textBox_IdFilter.Text);

            //מייצרים אוסף של כלל הלקוחות

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            employeeArr = employeeArr.Filter(id, textBox_FirstName.Text, textBox_LastNameFilter.Text,
            textBox_PhoneNumberFilter.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Employees.DataSource = employeeArr;

        }


        public Employee SelectedEmployee
        {
            get => listBox_Employees.SelectedItem as Employee;
        }

    }
}
