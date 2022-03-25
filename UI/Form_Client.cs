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
    public partial class Form_Client : Form
    {
        public Form_Client(Client client = null)
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            ClientArrToForm();
            CityArrToForm();
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
                Client client = FormToClient();

                if (label_Id.Text == "0")
                {
                    client.Insert();
                    MessageBox.Show("Saved");
                }

                else
                {
                    client.Update();
                    MessageBox.Show("Updated");
                }
                ClientArrToForm();

                label_Id.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_PhoneNumber.Text = "";
                CityArrToForm();
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

        private Client FormToClient()
        {
            Client client = new Client();
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Id = int.Parse(label_Id.Text);
            client.City = comboBox_City.SelectedItem as City;
            //בדיקה האם יש ערך בשדה להמרה

           
            if (textBox_PhoneNumber.Text != "")
            {
                client.PhoneNumber = int.Parse(textBox_PhoneNumber.Text);
            }
            return client;
        }



        private void ClientArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
            listBox_Clients.ValueMember = "Id";
            listBox_Clients.DisplayMember = "";
        }

        private void CityArrToForm(City curCity = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CityArr cityArr = new CityArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            City cityDefault = new City();
            cityDefault.Id = -1;
            cityDefault.Name = "Choose a city";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            cityArr.Add(cityDefault);

            cityArr.Fill();
            if (cityArr != null)
            {
                comboBox_City.DataSource = cityArr;
                comboBox_City.ValueMember = "Id";
                comboBox_City.DisplayMember = "Name";
            }


            if (curCity != null)
            {
                comboBox_City.SelectedValue = curCity.Id;
            }
        }

        private void ClientToForm(Client client)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס



            if (client != null)
            {
                label_Id.Text = client.Id.ToString();
                textBox_FirstName.Text = client.FirstName;
                textBox_LastName.Text = client.LastName;
                if (client.PhoneNumber > 999999999)
                {
                    textBox_PhoneNumber.Text = client.PhoneNumber.ToString();
                }
                else
                {
                    textBox_PhoneNumber.Text = "0" + client.PhoneNumber.ToString();
                }
                
                if (client.City != null)
                {
                    comboBox_City.SelectedValue = client.City.Id;
                }
            }

            else
            {
                label_Id.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_PhoneNumber.Text = "";
                CityArrToForm();
            }
        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            Client client = listBox_Clients.SelectedItem as Client;
            ClientToForm(client);
        }

        private void clear_Click(object sender, EventArgs e)
        {

            label_Id.Text = "0";
            textBox_FirstName.Text = "";
            textBox_LastName.Text = "";
            textBox_PhoneNumber.Text = "";
            CityArrToForm();
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            textBox_FirstNameFilter.Text = "";
            textBox_LastNameFilter.Text = "";
            textBox_PhoneNumberFilter.Text = "";
            ClientArrToForm();
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            Client client = FormToClient();
            if (client.Id == 0)
            {
                MessageBox.Show("You need to choose a client");
            }
            else

            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    client = FormToClient();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    OrderArr orderArr = new OrderArr();
                    orderArr.Fill();
                    if (orderArr.DoesExist(client))
                        MessageBox.Show("You can’t delete a city that is related to a client");
                    else
                    {
                        if (client.Delete())
                        {
                            MessageBox.Show("Deleted");
                        }

                        else
                        {
                            MessageBox.Show("Not Deleted");
                        }
                        ClientToForm(null);
                        ClientArrToForm();
                    }
                }
            }
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_IdFilter.Text != "")
            {
                id = int.Parse(textBox_IdFilter.Text);
            }

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש
            clientArr = clientArr.Filter(id, textBox_FirstNameFilter.Text, textBox_LastNameFilter.Text,
            textBox_PhoneNumberFilter.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;


        }

        private void button_AddCity_Click(object sender, EventArgs e)
        {
            Form_City form_City = new Form_City();
            form_City.ShowDialog();
            CityArrToForm(form_City.SelectedCity);
        }

        public Client SelectedClient
        {
            get => listBox_Clients.SelectedItem as Client;
        }

    }
}
