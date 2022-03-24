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
    public partial class Form_Artist : Form
    {
        public Form_Artist(Artist artist = null)
        {
            InitializeComponent();

            label_DateToday.Text = DateTime.Now.ToLongDateString();

            //טעינת אוסף הישובים לרשימה בטופס

            ArtistArrToForm(artist);
            ArtistToForm(artist);
        }

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private void textBox_Heb_KeyPress(object sender, KeyPressEventArgs e)
        {

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
                Artist artist = FormToArtist();

                if (label_Id.Text == "0")
                {
                    artist.Insert();
                    MessageBox.Show("Saved");
                }

                else
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

        private Artist FormToArtist()
        {
            Artist artist = new Artist();
            artist.Name = textBox_Name.Text;
            artist.Id = int.Parse(label_Id.Text);
            //בדיקה האם יש ערך בשדה להמרה


            return artist;
        }

        private void ArtistArrToForm(Artist curArtist = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ArtistArr artistArr = new ArtistArr();
            artistArr.Fill();
            listBox_Artists.DataSource = artistArr;
            listBox_Artists.ValueMember = "Id";
            listBox_Artists.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curArtist != null)
            {
                listBox_Artists.SelectedValue = curArtist.Id;
            }
        }

        private void ArtistToForm(Artist artist = null)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס



            if (artist != null)
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

        private void listBox_Artists_DoubleClick(object sender, EventArgs e)
        {
            Artist artist = listBox_Artists.SelectedItem as Artist;
            ArtistToForm(artist);
        }

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

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Artist artist = FormToArtist();
            if (artist.Id == 0)
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
                    artist = FormToArtist();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

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

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_IdFilter.Text != "")
                id = int.Parse(textBox_IdFilter.Text);

            //מייצרים אוסף של כלל הלקוחות

            ArtistArr artistArr = new ArtistArr();
            artistArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            artistArr = artistArr.Filter(id, textBox_NameFilter.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Artists.DataSource = artistArr;

        }

        public Artist SelectedArtist
        {
            get => listBox_Artists.SelectedItem as Artist;
        }

    }
}
