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
    public partial class Form_Genre : Form
    {
        public Form_Genre(Genre genre = null)
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            GenreArrToForm(genre);
            GenreToForm(genre);
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
                Genre genre = FormToGenre();

                if (label_Id.Text == "0")
                {
                    genre.Insert();
                    MessageBox.Show("Saved");
                }

                else
                {
                    genre.Update();
                    MessageBox.Show("Updated");
                }
                GenreArrToForm(genre);
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


        //המרות לגאנרים מהבי אל
        private Genre FormToGenre()
        {
            Genre genre = new Genre();
            genre.Name = textBox_Name.Text;
            genre.Id = int.Parse(label_Id.Text);
            //בדיקה האם יש ערך בשדה להמרה


            return genre;
        }
        private void GenreArrToForm(Genre curGenre = null)
        {

            //ממירה את הטנ "מ אוסף גאנרים לטופס

            GenreArr genreArr = new GenreArr();
            genreArr.Fill();
            listBox_Genres.DataSource = genreArr;
            listBox_Genres.ValueMember = "Id";
            listBox_Genres.DisplayMember = "Name";

            //אם נשלח לפעולה גאנר ,הצבתו בתיבת הבחירה של גאנרים בטופס

            if (curGenre != null)
            {
                listBox_Genres.SelectedValue = curGenre.Id;
            }
        }
        private void GenreToForm(Genre genre = null)
        {

            //ממירה את המידע בטנ "מ גאנר לטופס



            if (genre != null || genre.Id == -1 )
            {
                label_Id.Text = genre.Id.ToString();
                textBox_Name.Text = genre.Name;

            }

            else
            {
                label_Id.Text = "0";
                textBox_Name.Text = "";

            }
        }


        //ליסט בוקס
        private void listBox_Genres_DoubleClick(object sender, EventArgs e)
        {
            Genre genre = listBox_Genres.SelectedItem as Genre;
            GenreToForm(genre);
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
            GenreArrToForm();

        }


        //מחיקה
        private void button_Delete_Click(object sender, EventArgs e)
        {
            Genre genre = FormToGenre();
            if (genre.Id == 0)
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
                    genre = FormToGenre();

                    //לפני המחיקה - בדיקה שהגאנר לא בשימוש בישויות אחרות
                    //בדיקה עבור מוצרים

                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    if (productArr.DoesExist(genre))
                        MessageBox.Show("You can’t delete a genre that is related to a product");
                    else
                    {
                        if (genre.Delete())
                        {
                            MessageBox.Show("Deleted");
                        }

                        else
                        {
                            MessageBox.Show("Not Deleted");
                        }
                        GenreToForm(null);
                        GenreArrToForm();
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

            //מייצרים אוסף של כלל הגאנרים

            GenreArr genreArr = new GenreArr();
            genreArr.Fill();

            //מסננים את אוסף הגאנרים לפי שדות הסינון שרשם המשתמש

            genreArr = genreArr.Filter(id, textBox_NameFilter.Text);
            //מציבים בתיבת הרשימה את אוסף הגאנרים

            listBox_Genres.DataSource = genreArr;

        }


        //גאנר למוצר
        public Genre SelectedGenre
        {
            get => listBox_Genres.SelectedItem as Genre;
        }

    }
}
