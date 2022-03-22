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
    public partial class Form_Order : Form
    {
        public Form_Order(Order order = null)
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            OrderArrToForm(); 
            ClientArrToForm(comboBox_Client, true);
            ClientArrToForm(comboBox_ClientFilter, false);
            dateTimePicker_Date.Value = DateTime.Now; 
            ClientArrToForm(comboBox_ClientFilter, false);
            dateTimePicker_FromDateFilter.Value = new DateTime(2000, 1, 1, 0, 0, 0);
            dateTimePicker_ToDateFilter.Value = new DateTime(9000, 1, 1, 0, 0, 0); ;

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
                Order order = FormToOrder();

                if (label_Id.Text == "0")
                {
                    order.Insert();
                    MessageBox.Show("Saved");
                }

                else
                {
                    order.Update();
                    MessageBox.Show("Updated");
                }
                OrderArrToForm();

            }
        }

        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            if ((comboBox_Client.SelectedItem as Client).Id < 0)
            {
                flag = false;
                label_Client.ForeColor = Color.Red;
            }
            else
            {
                label_Client.ForeColor = Color.Black;
            }


            return flag;
        }

        private Order FormToOrder()
        {
            Order order = new Order();
            order.Note = richTextBox_Note.Text;
            order.Id = int.Parse(label_Id.Text);
            order.Client = comboBox_Client.SelectedItem as Client;
            order.Date = dateTimePicker_Date.Value;
            //בדיקה האם יש ערך בשדה להמרה

            return order;
        }



        private void OrderArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            listBox_Orders.DataSource = orderArr;
            listBox_Orders.ValueMember = "Id";
            listBox_Orders.DisplayMember = "";
        }

        private void ClientArrToForm(ComboBox comboBox, bool isMustChoose, Client curClient = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Client clientDefault = new Client();
            clientDefault.Id = -1;

            if (isMustChoose)
            {
                clientDefault.FirstName = "Choose a client";
                clientDefault.LastName = "";
            }
            else
            {
                clientDefault.FirstName = "All categories";
                clientDefault.LastName = "";
            }

            clientArr.Add(clientDefault);
            clientArr.Fill();
            comboBox.DataSource = clientArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "";

            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            clientArr.Add(clientDefault);


            if (curClient != null)
            {
                comboBox_Client.SelectedValue = curClient.Id;
            }
        }

        private void OrderToForm(Order order)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס



            if (order != null)
            {
                label_Id.Text = order.Id.ToString();
                richTextBox_Note.Text = order.Note;
                if (order.Client != null)
                {
                    comboBox_Client.SelectedValue = order.Client.Id;
                }
                dateTimePicker_Date.Value = order.Date;
            }

            else
            {
                label_Id.Text = "0";
                richTextBox_Note.Text = "";
                dateTimePicker_Date.Value = DateTime.Now;
                ClientArrToForm(comboBox_Client, true);
            }
        }

        private void listBox_Orders_DoubleClick(object sender, EventArgs e)
        {
            Order order = listBox_Orders.SelectedItem as Order;
            OrderToForm(order);
        }

        private void clear_Click(object sender, EventArgs e)
        {

            label_Id.Text = "0";
            richTextBox_Note.Text = "";
            dateTimePicker_Date.Value = DateTime.Now;
            ClientArrToForm(comboBox_Client, true);
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            ClientArrToForm(comboBox_ClientFilter, false);
            dateTimePicker_FromDateFilter.Value = DateTime.MinValue;
            dateTimePicker_ToDateFilter.Value = DateTime.MaxValue;

        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            Order order = FormToOrder();
            if (order.Id == 0)
            {
                MessageBox.Show("You need to choose a order");
            }
            else

            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (order.Delete())
                    {
                        MessageBox.Show("Deleted");
                    }

                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                    OrderToForm(null);
                    OrderArrToForm();
                }
            }
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetOrdersByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_ClientFilter.SelectedItem as Category != null &&
                (comboBox_ClientFilter.SelectedItem as Category).Id > 0)
            {
                SetOrdersByFilter();
            }
            
        }

        private void dateTimePicker_DateFilter_ValueChanged(object sender, EventArgs e)
        {
            SetOrdersByFilter();
        }


        private void SetOrdersByFilter()
        {
            int id = 0;
            //מייצרים אוסף של כלל המוצרים
            if (textBox_IdFilter.Text != "")
                id = int.Parse(textBox_IdFilter.Text);

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            orderArr = orderArr.Filter(id,
            comboBox_Client.SelectedItem as Client,
            dateTimePicker_FromDateFilter.Value,
            dateTimePicker_ToDateFilter.Value
            );

            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_Orders.DataSource = orderArr;
        }

        private void button_AddClient_Click(object sender, EventArgs e)
        {
            Form_Client form_Client = new Form_Client(comboBox_Client.SelectedItem as Client);
            form_Client.ShowDialog();
            ClientArrToForm(comboBox_Client, true, form_Client.SelectedClient);
        }

        public Order SelectedOrder
        {
            get => listBox_Orders.SelectedItem as Order;
        }

        
    }
}
