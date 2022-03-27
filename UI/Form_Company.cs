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
    public partial class Form_Company : Form
    {
        public Form_Company(Company company = null)
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            CompanyArrToForm(company);
            CompanyToForm(company);
        }

        //הגבלת הכנסת פרטים
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


        //שמירה
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
                Company company = FormToCompany();

                if (label_Id.Text == "0")
                {
                    company.Insert();
                    MessageBox.Show("Saved");
                }

                else
                {
                    company.Update();
                    MessageBox.Show("Updated");
                }
                CompanyArrToForm(company);
                label_Id.Text = "0";
                textBox_Name.Text = "";

            }
        }
        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            //בדיקת שם  //

            if (textBox_Name.Text.Length < 2)
            {
                flag = false;
                label_Name.ForeColor = Color.Red;
            }
            else
                label_Name.ForeColor = Color.Black;





            return flag;
        }

        //המרות לחברות מהבי אל
        private Company FormToCompany()
        {
            Company company = new Company();
            company.Name = textBox_Name.Text;
            company.Id = int.Parse(label_Id.Text);
            //בדיקה האם יש ערך בשדה להמרה


            return company;
        }
        private void CompanyArrToForm(Company curCompany = null)
        {

            //ממירה את הטנ "מ אוסף חברות לטופס

            CompanyArr companyArr = new CompanyArr();
            companyArr.Fill();
            listBox_Companies.DataSource = companyArr;
            listBox_Companies.ValueMember = "Id";
            listBox_Companies.DisplayMember = "Name";

            //אם נשלח לפעולה חברה ,הצבתו בתיבת הבחירה של חברהים בטופס

            if (curCompany != null)
            {
                listBox_Companies.SelectedValue = curCompany.Id;
            }
        }
        private void CompanyToForm(Company company = null)
        {

            //ממירה את המידע בטנ "מ חברה לטופס



            if (company != null || company.Id == -1)
            {
                label_Id.Text = company.Id.ToString();
                textBox_Name.Text = company.Name;

            }

            else
            {
                label_Id.Text = "0";
                textBox_Name.Text = "";

            }
        }


        //ליסט בוקס
        private void listBox_Companies_DoubleClick(object sender, EventArgs e)
        {
            Company company = listBox_Companies.SelectedItem as Company;
            CompanyToForm(company);
        }


        //ניקוי טופס
        private void clear_Click(object sender, EventArgs e)
        {
            label_Id.Text = "0";
            textBox_Name.Text = "";

        }
        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            textBox_NameFilter.Text = "";
            CompanyArrToForm();

        }


        //מחיקה
        private void button_Delete_Click(object sender, EventArgs e)
        {
            Company company = FormToCompany();
            if (company.Id == 0)
            {
                MessageBox.Show("You need to choose a product");
            }
            else

            {

                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    company = FormToCompany();

                    //לפני המחיקה - בדיקה שהחברה לא בשימוש בישויות אחרות
                    //בדיקה עבור מוצרים

                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    if (productArr.DoesExist(company))
                        MessageBox.Show("You can’t delete a company that is related to a product");
                    else
                    {
                        if (company.Delete())
                        {
                            MessageBox.Show("Deleted");
                        }

                        else
                        {
                            MessageBox.Show("Not Deleted");
                        }
                        CompanyToForm(null);
                        CompanyArrToForm();
                    }
                }
            }
        }


        //פילטר
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_IdFilter.Text != "")
                id = int.Parse(textBox_IdFilter.Text);

            //מייצרים אוסף של כלל החברות

            CompanyArr companyArr = new CompanyArr();
            companyArr.Fill();

            //מסננים את אוסף החברות לפי שדות הסינון שרשם המשתמש

            companyArr = companyArr.Filter(id, textBox_NameFilter.Text);
            //מציבים בתיבת הרשימה את אוסף החברות

            listBox_Companies.DataSource = companyArr;

        }

        //חברה למוצר
        public Company SelectedCompany
        {
            get => listBox_Companies.SelectedItem as Company;
        }

    }
}
