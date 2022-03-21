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
    public partial class Form_Product : Form
    {
        public Form_Product(Product product = null)
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            ProductArrToForm();
            CategoryArrToForm();
            GenreArrToForm();
            ArtistArrToForm();
            CompanyArrToForm();
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
                Product product = FormToProduct();

                if (label_Id.Text == "0")
                {
                    product.Insert();
                    MessageBox.Show("Saved");
                }

                else
                {
                    product.Update();
                    MessageBox.Show("Updated");
                }
                ProductArrToForm();

            }
        }

        /*/
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

            if (textBox_ZipCode.Text.Length != 7)
            {
                flag = false;
                label_ZipCode.ForeColor = Color.Red;
            }
            else
            {
                label_ZipCode.ForeColor = Color.Black;
            }

            if ((comboBox_City.SelectedItem as City).Id < 0)
            {
                flag = false;
                label_City.ForeColor = Color.Red;
            }
            else
            {
                label_City.ForeColor = Color.Black;
            }


            return flag;
        }

        /*/

        private Product FormToProduct()
        {
            Product product = new Product();
            product.Category = comboBox_Category.SelectedItem as Category;
            product.Name = textBox_Name.Text;
            Genre genre = comboBox_Genre.SelectedItem as Genre;
            if (genre.Id >= 0 )
            {
                product.Genre = comboBox_Genre.SelectedItem as Genre;
            }
            Artist artist = comboBox_Artist.SelectedItem as Artist;
            if (artist.Id >= 0)
            {
                product.Artist = comboBox_Artist.SelectedItem as Artist;
            }
            product.Company = comboBox_Company.SelectedItem as Company;
            product.IsNew = checkBox_IsNew.Checked;
            product.Price = int.Parse(textBox_Price.Text);
            product.Count = int.Parse(textBox_Count.Text);
            product.Id = int.Parse(label_Id.Text);
            //בדיקה האם יש ערך בשדה להמרה

            return product;
        }



        private void ProductArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ProductArr productArr = new ProductArr();
            productArr.Fill();
            listBox_Products.DataSource = productArr;
            listBox_Products.ValueMember = "Id";
            listBox_Products.DisplayMember = "";
        }

        private void CategoryArrToForm(Category curCategory = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CategoryArr categoryArr = new CategoryArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Category categoryDefault = new Category();
            categoryDefault.Id = -1;
            categoryDefault.Name = "בחר קטגוריה";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            categoryArr.Add(categoryDefault);

            categoryArr.Fill();
            if (categoryArr != null)
            {
                comboBox_Category.DataSource = categoryArr;
                comboBox_Category.ValueMember = "Id";
                comboBox_Category.DisplayMember = "Name";
            }


            if (curCategory != null)
            {
                comboBox_Category.SelectedValue = curCategory.Id;
            }
        }

        private void GenreArrToForm(Genre curGenre = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            GenreArr genreArr = new GenreArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Genre genreDefault = new Genre();
            genreDefault.Id = -1;
            genreDefault.Name = "בחר ז'אנר";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            genreArr.Add(genreDefault);

            genreArr.Fill();
            if (genreArr != null)
            {
                comboBox_Genre.DataSource = genreArr;
                comboBox_Genre.ValueMember = "Id";
                comboBox_Genre.DisplayMember = "Name";
            }


            if (curGenre != null)
            {
                comboBox_Genre.SelectedValue = curGenre.Id;
            }
        }

        private void ArtistArrToForm(Artist curArtist = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ArtistArr artistArr = new ArtistArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Artist artistDefault = new Artist();
            artistDefault.Id = -1;
            artistDefault.Name = "בחר אמן";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            artistArr.Add(artistDefault);

            artistArr.Fill();
            if (artistArr != null)
            {
                comboBox_Artist.DataSource = artistArr;
                comboBox_Artist.ValueMember = "Id";
                comboBox_Artist.DisplayMember = "Name";
            }


            if (curArtist != null)
            {
                comboBox_Artist.SelectedValue = curArtist.Id;
            }
        }

        private void CompanyArrToForm(Company curCompany = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CompanyArr companyArr = new CompanyArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Company companyDefault = new Company();
            companyDefault.Id = -1;
            companyDefault.Name = "בחר יצרן";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            companyArr.Add(companyDefault);

            companyArr.Fill();
            if (companyArr != null)
            {
                comboBox_Company.DataSource = companyArr;
                comboBox_Company.ValueMember = "Id";
                comboBox_Company.DisplayMember = "Name";
            }


            if (curCompany != null)
            {
                comboBox_Company.SelectedValue = curCompany.Id;
            }
        }

        private void ProductToForm(Product product)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס



            if (product != null)
            {
                label_Id.Text = product.Id.ToString();
                comboBox_Category.SelectedValue = product.Category.Id;
                textBox_Name.Text = product.Name;
                if (product.Genre != null)
                {
                    comboBox_Genre.SelectedValue = product.Genre.Id;
                }
                if (product.Artist != null)
                {
                    comboBox_Artist.SelectedValue = product.Artist.Id;
                }
                comboBox_Company.SelectedValue = product.Company.Id;
                checkBox_IsNew.Checked = product.IsNew;
                textBox_Price.Text = product.Price.ToString();
                textBox_Count.Text = product.Count.ToString();
            }

            else
            {
                label_Id.Text = "0";
                CategoryArrToForm();
                textBox_Name.Text = "";
                GenreArrToForm();
                ArtistArrToForm();
                CompanyArrToForm();
                checkBox_IsNew.Checked = false;
                textBox_Price.Text = "";
                textBox_Count.Text = "";
            }
        }

        private void listBox_Products_DoubleClick(object sender, EventArgs e)
        {
            Product product = listBox_Products.SelectedItem as Product;
            ProductToForm(product);
        }

        private void clear_Click(object sender, EventArgs e)
        {

            label_Id.Text = "0";
            CategoryArrToForm();
            textBox_Name.Text = "";
            GenreArrToForm();
            ArtistArrToForm();
            CompanyArrToForm();
            checkBox_IsNew.Checked = false;
            textBox_Price.Text = "";
            textBox_Count.Text = "";
        }
        //
        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            textBox_FirstNameFilter.Text = "";
            textBox_LastNameFilter.Text = "";
            textBox_PhoneNumberFilter.Text = "";
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            Product product = FormToProduct();
            if (product.Id == 0)
            {
                MessageBox.Show("You need to choose a product");
            }
            else

            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (product.Delete())
                    {
                        MessageBox.Show("Deleted");
                    }

                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                    ProductToForm(null);
                    ProductArrToForm();
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

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(id, textBox_FirstName.Text, textBox_LastNameFilter.Text,
            textBox_PhoneNumberFilter.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Products.DataSource = productArr;

        }

        private void button_AddCategory_Click(object sender, EventArgs e)
        {
            Form_Category form_Category = new Form_Category(comboBox_Category.SelectedItem as Category);
            form_Category.ShowDialog();
            CategoryArrToForm(form_Category.SelectedCategory);
        }

        private void button_AddGenre_Click(object sender, EventArgs e)
        {
            Form_Genre form_Genre = new Form_Genre(comboBox_Genre.SelectedItem as Genre);
            form_Genre.ShowDialog();
            GenreArrToForm(form_Genre.SelectedGenre);
        }

        private void button_AddArtist_Click(object sender, EventArgs e)
        {
            Form_Artist form_Artist = new Form_Artist(comboBox_Artist.SelectedItem as Artist);
            form_Artist.ShowDialog();
            ArtistArrToForm(form_Artist.SelectedArtist);
        }

        private void button_AddCompany_Click(object sender, EventArgs e)
        {
            Form_Company form_Company = new Form_Company(comboBox_Company.SelectedItem as Company);
            form_Company.ShowDialog();
            CompanyArrToForm(form_Company.SelectedCompany);
        }

        public Product SelectedProduct
        {
            get => listBox_Products.SelectedItem as Product;
        }

    }
}
//לסדר את הפילטר ואת הדיקה של החרא