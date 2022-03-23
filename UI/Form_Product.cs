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
            CategoryArrToForm(comboBox_Category, true);
            CategoryArrToForm(comboBox_CategoryFilter, false);

            GenreArrToForm(comboBox_Genre, true);

            ArtistArrToForm(comboBox_Artist, true);
            ArtistArrToForm(comboBox_ArtistFilter, false);

            CompanyArrToForm(comboBox_Company, true);
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
                label_Id.Text = "0";
                CategoryArrToForm(comboBox_Category, true);
                textBox_Name.Text = "";
                GenreArrToForm(comboBox_Genre, true);
                ArtistArrToForm(comboBox_Artist, true);
                CompanyArrToForm(comboBox_Company, true);
                checkBox_IsNew.Checked = false;
                textBox_Price.Text = "";
                numericUpDown_Count.Value = 0;

            }
        }

        
        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            //בדיקת שם פרטי //

            if (textBox_Name.Text.Length < 2)
            {
                flag = false;
                label_Name.ForeColor = Color.Red;
            }
            else
                label_Name.ForeColor = Color.Black;

            //בדיקת שם משפחה //

            //בדיקת מספר טלפון //

            if (textBox_Price.Text == null)
            {
                flag = false;
                label_Price.ForeColor = Color.Red;
            }
            else
                label_Price.ForeColor = Color.Black;

            //בדיקת מיקוד //
            


            if (numericUpDown_Count.Value<0)
            {
                flag = false;
                label_Count.ForeColor = Color.Red;
            }
            else
            {
                label_Count.ForeColor = Color.Black;
            }

            if ((comboBox_Category.SelectedItem as Category).Id < 0)
            {
                flag = false;
                label_Category.ForeColor = Color.Red;
            }
            else
            {
                label_Category.ForeColor = Color.Black;
            }

            if ((comboBox_Genre.SelectedItem as Genre).Id < 0)
            {
                flag = false;
                label_Genre.ForeColor = Color.Red;
            }
            else
            {
                label_Genre.ForeColor = Color.Black;
            }

            if ((comboBox_Artist.SelectedItem as Artist).Id < 0)
            {
                flag = false;
                label_Artist.ForeColor = Color.Red;
            }
            else
            {
                label_Artist.ForeColor = Color.Black;
            }

            if ((comboBox_Company.SelectedItem as Company).Id < 0)
            {
                flag = false;
                label_Company.ForeColor = Color.Red;
            }
            else
            {
                label_Company.ForeColor = Color.Black;
            }


            return flag;
        }

        

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
            product.Count = int.Parse(numericUpDown_Count.Value.ToString());
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

        private void CategoryArrToForm(ComboBox comboBox, bool isMustChoose, Category curCategory = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CategoryArr categoryArr = new CategoryArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Category categoryDefault = new Category();
            categoryDefault.Id = -1;

            if (isMustChoose)
            {
                categoryDefault.Name = "Choose a category";
            }
            else
            {
                categoryDefault.Name = "All categories";
            }

            categoryArr.Add(categoryDefault);
            categoryArr.Fill();
            comboBox.DataSource = categoryArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            categoryArr.Add(categoryDefault);


            if (curCategory != null)
            {
                comboBox_Category.SelectedValue = curCategory.Id;
            }
        }

        private void GenreArrToForm(ComboBox comboBox, bool isMustChoose, Genre curGenre = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            GenreArr genreArr = new GenreArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Genre genreDefault = new Genre();
            genreDefault.Id = -1;

            if (isMustChoose)
            {
                genreDefault.Name = "Choose a genre";
            }
            else
                genreDefault.Name = "All categories";
            genreArr.Add(genreDefault);
            genreArr.Fill();
            comboBox.DataSource = genreArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            genreArr.Add(genreDefault);


            if (curGenre != null)
            {
                comboBox_Genre.SelectedValue = curGenre.Id;
            }
        }

        private void ArtistArrToForm(ComboBox comboBox, bool isMustChoose, Artist curArtist = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ArtistArr artistArr = new ArtistArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Artist artistDefault = new Artist();
            artistDefault.Id = -1;

            if (isMustChoose)
            {
                artistDefault.Name = "Choose a artist";
            }
            else
                artistDefault.Name = "All categories";
            artistArr.Add(artistDefault);
            artistArr.Fill();
            comboBox.DataSource = artistArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            artistArr.Add(artistDefault);


            if (curArtist != null)
            {
                comboBox_Artist.SelectedValue = curArtist.Id;
            }
        }

        private void CompanyArrToForm(ComboBox comboBox, bool isMustChoose, Company curCompany = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CompanyArr companyArr = new CompanyArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Company companyDefault = new Company();
            companyDefault.Id = -1;

            if (isMustChoose)
            {
                companyDefault.Name = "Choose a company";
            }
            else
                companyDefault.Name = "All categories";
            companyArr.Add(companyDefault);
            companyArr.Fill();
            comboBox.DataSource = companyArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            companyArr.Add(companyDefault);


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
                numericUpDown_Count.Value = product.Count;
            }

            else
            {
                label_Id.Text = "0";
                CategoryArrToForm(comboBox_Category, true);
                textBox_Name.Text = "";
                GenreArrToForm(comboBox_Genre, true);
                ArtistArrToForm(comboBox_Artist, true);
                CompanyArrToForm(comboBox_Company, true);
                checkBox_IsNew.Checked = false;
                textBox_Price.Text = "";
                numericUpDown_Count.Value = 0;
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
            CategoryArrToForm(comboBox_Category, true);
            textBox_Name.Text = "";
            GenreArrToForm(comboBox_Genre, true);
            ArtistArrToForm(comboBox_Artist, true);
            CompanyArrToForm(comboBox_Company, true);
            checkBox_IsNew.Checked = false;
            textBox_Price.Text = "";
            numericUpDown_Count.Value = 0;
        }
        
        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            CategoryArrToForm(comboBox_CategoryFilter, false);
            textBox_NameFilter.Text = "";
            ArtistArrToForm(comboBox_ArtistFilter, false);
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
            SetProductsByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_CategoryFilter.SelectedItem as Category != null &&
                comboBox_ArtistFilter.SelectedItem as Artist != null &&
                (comboBox_CategoryFilter.SelectedItem as Category).Id > 0 &&
                (comboBox_ArtistFilter.SelectedItem as Artist).Id > 0)
            {
                SetProductsByFilter();
            }
        }
        private void SetProductsByFilter()
        {
            int id = 0;
            //מייצרים אוסף של כלל המוצרים
            if (textBox_IdFilter.Text != "")
                id = int.Parse(textBox_IdFilter.Text);

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(id,
            textBox_NameFilter.Text,
            comboBox_CategoryFilter.SelectedItem as Category,
            comboBox_ArtistFilter.SelectedItem as Artist
            );

            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_Products.DataSource = productArr;
        }

        private void button_AddCategory_Click(object sender, EventArgs e)
        {
            Form_Category form_Category = new Form_Category();
            form_Category.ShowDialog();
            CategoryArrToForm(comboBox_Category, true, form_Category.SelectedCategory);
        }

        private void button_AddGenre_Click(object sender, EventArgs e)
        {
            Form_Genre form_Genre = new Form_Genre();
            form_Genre.ShowDialog();
            GenreArrToForm(comboBox_Genre, true, form_Genre.SelectedGenre);
        }

        private void button_AddArtist_Click(object sender, EventArgs e)
        {
            Form_Artist form_Artist = new Form_Artist();
            form_Artist.ShowDialog();
            ArtistArrToForm(comboBox_Artist, true, form_Artist.SelectedArtist);
        }

        private void button_AddCompany_Click(object sender, EventArgs e)
        {
            Form_Company form_Company = new Form_Company();
            form_Company.ShowDialog();
            CompanyArrToForm(comboBox_Company, true, form_Company.SelectedCompany);
        }

        public Product SelectedProduct
        {
            get => listBox_Products.SelectedItem as Product;
        }

    }
}
