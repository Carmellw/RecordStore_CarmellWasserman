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
    public partial class Form_Artist : Form
    {
        public Form_Artist(Artist artist = null)
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            ArtistArrToForm(artist);
            ArtistToForm(artist);
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
                Artist artist = FormToArtist();

                if (label_Id.Text == "0")//שמירה חדש
                {
                    artist.Insert();
                    MessageBox.Show("Saved");
                }

                else//עדכון
                {
                    artist.Update();
                    MessageBox.Show("Updated");
                }
                ArtistArrToForm(artist);
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


        //המרות לאמנים מהבי אל
        private Artist FormToArtist()//מכניס פרטים של אמן לטופס 
        {
            Artist artist = new Artist();
            artist.Name = textBox_Name.Text;
            artist.Id = int.Parse(label_Id.Text);
            //בדיקה האם יש ערך בשדה להמרה
            return artist;
        }
        private void ArtistArrToForm(Artist curArtist = null)
        {

            //ממירה את הטנ "מ אוסף אמנים לטופס

            ArtistArr artistArr = new ArtistArr();
            artistArr.Fill();
            listBox_Artists.DataSource = artistArr;
            listBox_Artists.ValueMember = "Id";
            listBox_Artists.DisplayMember = "Name";
            if (curArtist != null)
            {
                listBox_Artists.SelectedValue = curArtist.Id;
            }
        } 
        private void ArtistToForm(Artist artist = null)
        {

            //ממירה את המידע בטנ "מ אמן לטופס



            if (artist != null || artist.Id == -1)
            {
                label_Id.Text = artist.Id.ToString();
                textBox_Name.Text = artist.Name;

            }

            else
            {
                label_Id.Text = "0";
                textBox_Name.Text = "";

            }
        }


        //ליסט בוקס
        private void listBox_Artists_DoubleClick(object sender, EventArgs e)
        {
            Artist artist = listBox_Artists.SelectedItem as Artist;
            ArtistToForm(artist);
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
            ArtistArrToForm();

        }


        //מחיקה
        private void button_Delete_Click(object sender, EventArgs e)
        {
            Artist artist = FormToArtist();
            if (artist.Id == 0)
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
                    artist = FormToArtist();

                    //לפני המחיקה - בדיקה שהאמן לא בשימוש בישויות אחרות
                    //בדיקה עבור מוצרים

                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    if (productArr.DoesExist(artist))
                        MessageBox.Show("You can’t delete a artist that is related to a product");
                    else
                    {
                        if (artist.Delete())
                        {
                            MessageBox.Show("Deleted");
                        }

                        else
                        {
                            MessageBox.Show("Not Deleted");
                        }
                        ArtistToForm(null);
                        ArtistArrToForm();
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

            //מייצרים אוסף של כלל האמנים

            ArtistArr artistArr = new ArtistArr();
            artistArr.Fill();

            //מסננים את אוסף האמנים לפי שדות הסינון שרשם המשתמש

            artistArr = artistArr.Filter(id, textBox_NameFilter.Text);
            //מציבים בתיבת הרשימה את אוסף האמנים

            listBox_Artists.DataSource = artistArr;

        }


        //אמן למוצר
        public Artist SelectedArtist
        {
            get => listBox_Artists.SelectedItem as Artist;
        }

    }
}
