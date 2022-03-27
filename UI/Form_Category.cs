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
    public partial class Form_Category : Form
    {
        public Form_Category(Category category = null)
        {
            InitializeComponent();

            label_DateToday.Text = DateTime.Now.ToLongDateString();
            CategoryArrToForm(category);
            CategoryToForm(category);
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
                Category category = FormToCategory();

                if (label_Id.Text == "0")//שמירת חדש
                {
                    category.Insert();
                    MessageBox.Show("Saved");
                }

                else//עדכון
                {
                    category.Update();
                    MessageBox.Show("Updated");
                }
                CategoryArrToForm(category);
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


        //המרות לקטגוריות מהבי אל
        private Category FormToCategory()
        {
            Category category = new Category();
            category.Name = textBox_Name.Text;
            category.Id = int.Parse(label_Id.Text);
            //בדיקה האם יש ערך בשדה להמרה


            return category;
        }

        private void CategoryArrToForm(Category curCategory = null)
        {

            //ממירה את הטנ "מ אוסף קטגוריות לטופס

            CategoryArr categoryArr = new CategoryArr();
            categoryArr.Fill();
            listBox_Categories.DataSource = categoryArr;
            listBox_Categories.ValueMember = "Id";
            listBox_Categories.DisplayMember = "Name";
            if (curCategory != null)
            {
                listBox_Categories.SelectedValue = curCategory.Id;
            }
        }

        private void CategoryToForm(Category category = null)
        {

            //ממירה את המידע בטנ "מ קטגוריה לטופס



            if (category != null || category.Id == -1)
            {
                label_Id.Text = category.Id.ToString();
                textBox_Name.Text = category.Name;

            }

            else
            {
                label_Id.Text = "0";
                textBox_Name.Text = "";

            }
        }


        //ליסט בוקס
        private void listBox_Categories_DoubleClick(object sender, EventArgs e)
        {
            Category category = listBox_Categories.SelectedItem as Category;
            CategoryToForm(category);
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
            CategoryArrToForm();

        }

        //מחיקה
        private void button_Delete_Click(object sender, EventArgs e)
        {
            Category category = FormToCategory();
            if (category.Id == 0)
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
                    category = FormToCategory();

                    //לפני המחיקה - בדיקה שהקטגוריה לא בשימוש בישויות אחרות
                    //בדיקה עבור מוצרים

                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    if (productArr.DoesExist(category))
                        MessageBox.Show("You can’t delete a category that is related to a product");
                    else
                    {
                        if (category.Delete())
                        {
                            MessageBox.Show("Deleted");
                        }

                        else
                        {
                            MessageBox.Show("Not Deleted");
                        }
                        CategoryToForm(null);
                        CategoryArrToForm();
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

            //מייצרים אוסף של כלל הקטגוריות

            CategoryArr categoryArr = new CategoryArr();
            categoryArr.Fill();

            //מסננים את אוסף הקטגוריות לפי שדות הסינון שרשם המשתמש

            categoryArr = categoryArr.Filter(id, textBox_NameFilter.Text);
            //מציבים בתיבת הרשימה את אוסף הקטגוריות

            listBox_Categories.DataSource = categoryArr;

        }

        public Category SelectedCategory
        {
            get => listBox_Categories.SelectedItem as Category;
        }

    }
}
