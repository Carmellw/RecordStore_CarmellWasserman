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
    public partial class Form_Order : Form
    {
        private bool filterDate = false;
        public Form_Order(Order order = null)
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();

            //הכנסה לטופס פרטים
            OrderArrToForm();
            ClientArrToForm(comboBox_Client, true);
            ClientArrToForm(comboBox_ClientFilter, false);
            dateTimePicker_Date.Value = DateTime.Now;
            filterDate = false;
            dateTimePicker_FromDateFilter.Value = DateTime.Now;
            dateTimePicker_ToDateFilter.Value = DateTime.Now;

            //הכנסה לטופס מוצרים
            ProductArrToForm(listBox_Products);
            ClientArrToForm();
            CategoryArrToForm(comboBox_CategoryFilterProduct, false);
            ArtistArrToForm(comboBox_ArtistFilterProduct, false);

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
                Order order = FormToOrder();
                OrderProductArr orderProductArr_New;

                if (label_Id.Text == "0")
                {
                    if (order.Insert())
                    {
                        OrderArr orderArr = new OrderArr();
                        orderArr.Fill();
                        order = orderArr.GetOrderWithMaxId();
                        orderProductArr_New = FormToOrderProductArr(order);

                        //מוסיפים את הפריטים החדשים להזמנה

                        if (orderProductArr_New.Insert())
                        {
                            MessageBox.Show("Successfully saved");
                            //מעדכנים את מלאי הפריטים שהוזמנו

                            (listBox_InOrderProducts.DataSource as ProductArr).UpdateCount();
                        }
                        else
                            MessageBox.Show("Error in insert");
                    }
                }

                else
                {
                    if (order.Update())
                    {

                        //מוחקים את הפריטים הקודמים של ההזמנה
                        //אוסף כלל הזוגות - הזמנה-פריט

                        OrderProductArr orderProductArr_Old = new OrderProductArr();
                        orderProductArr_Old.Fill();

                        //סינון לפי ההזמנה הנוכחית

                        orderProductArr_Old = orderProductArr_Old.FilterOrder(order);

                        //מחיקת כל הפריטים באוסף ההזמנה-פריט של ההזמנה הנוכחית

                        orderProductArr_Old.Delete();

                        //מוסיפים את הפריטים לפי העדכני להזמנה

                        orderProductArr_New = FormToOrderProductArr(order);
                        orderProductArr_New.Insert();
                        //מעדכנים את מלאי הפריטים, אלו שהוזמנו ואלו שבפוטנציאל

                        (listBox_InOrderProducts.DataSource as ProductArr).UpdateCount();
                        (listBox_Products.DataSource as ProductArr).UpdateCount();
                    }
                    else
                        MessageBox.Show("Error");
                }
                OrderArrToForm();
                label_Id.Text = "0";
                richTextBox_Note.Text = "";
                dateTimePicker_Date.Value = DateTime.Now;
                ClientArrToForm(comboBox_Client, true);
                listBox_InOrderProducts.DataSource = null;
                listBox_InOrderProductsCount.Items.Clear();
                listBox_Products.DataSource = null;
                ProductArrToForm(listBox_Products);
                PaymentToForm();
                CategoryArrToForm(comboBox_CategoryFilterProduct, false);
                ArtistArrToForm(comboBox_ArtistFilterProduct, false);


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

            if (listBox_InOrderProducts.Items.Count == 0)
            {
                flag = false;
                MessageBox.Show("choose items");
            }




            return flag;
        }


        //המרות להזמנות מהבי אל
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

            //ממירה את הטנ "מ אוסף הזמנות לטופס

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            listBox_Orders.DataSource = orderArr;
            listBox_Orders.ValueMember = "Id";
            listBox_Orders.DisplayMember = "";
        }
        private void OrderToForm(Order order)
        {

            //ממירה את המידע בטנ "מ הזמנה לטופס



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


        //המרות מוצרים מהבי אל
        private void ProductArrToForm(ListBox listBox, ProductArr productArr = null)
        {

            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (productArr == null)
            {
                productArr = new ProductArr();
                productArr.Fill();
            }
            listBox.DataSource = productArr;

        }
        private void CategoryArrToForm(ComboBox comboBox, bool isMustChoose, Category curCategory = null)
        {

            //ממירה את הטנ "מ אוסף קטגוריות לטופס

            CategoryArr categoryArr = new CategoryArr();

            //הוספת קטגוריה ברירת מחדל - בחר קטגוריה
            //יצירת מופע חדש של קטגוריה עם מזהה מינוס 1 ושם מתאים

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

            //הוספת הקטגוריה לאוסף הקטגוריות - אותו נציב במקור הנתונים של תיבת הבחירה

            categoryArr.Add(categoryDefault);


            if (curCategory != null)
            {
                comboBox_CategoryFilterProduct.SelectedValue = curCategory.Id;
            }
        }
        private void ArtistArrToForm(ComboBox comboBox, bool isMustChoose, Artist curArtist = null)
        {

            //ממירה את הטנ "מ אוסף אמנים לטופס

            ArtistArr artistArr = new ArtistArr();

            //הוספת אמן ברירת מחדל - בחר אמן
            //יצירת מופע חדש של אמן עם מזהה מינוס 1 ושם מתאים

            Artist artistDefault = new Artist();
            artistDefault.Id = -1;

            if (isMustChoose)
            {
                artistDefault.Name = "Choose a artist";
            }
            else
                artistDefault.Name = "All artists";
            artistArr.Add(artistDefault);
            artistArr.Fill();
            comboBox.DataSource = artistArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
            //הוספת האמן לאוסף האמנים - אותו נציב במקור הנתונים של תיבת הבחירה

            artistArr.Add(artistDefault);


            if (curArtist != null)
            {
                comboBox_ArtistFilterProduct.SelectedValue = curArtist.Id;
            }


        }


        //המרות הזמנה-מוצר מהבי אל
        private OrderProductArr FormToOrderProductArr(Order curOrder = null)
        {

            // יצירת אוסף המוצרים להזמנה מהטופס
            // מייצרים זוגות של הזמנה-מוצר , ההזמנה - תמיד אותה הזמנה )הרי מדובר על הזמנה אחת(, המוצר - מגיע מרשימת המוצרים שנבחרו
            OrderProductArr orderProductArr = new OrderProductArr();
            /*/
            יצירת אוסף הזוגות הזמנה -מוצר /*/
            OrderProduct orderProduct;

            //סורקים את כל הערכים בתיבת הרשימה של המוצרים שנבחרו להזמנה
            for (int i = 0; i < listBox_InOrderProducts.Items.Count; i++)
            {
                orderProduct = new OrderProduct();

                //ההזמנה הנוכחית היא ההזמנה לכל הזוגות באוסף

                orderProduct.Order = curOrder;

                //מוצר נוכחי לזוג הזמנה-מוצר

                orderProduct.Product = listBox_InOrderProducts.Items[i] as Product;

                //כמות מוצר נוכחי לזוג הזמנה-מוצר
                orderProduct.Count = (int)listBox_InOrderProductsCount.Items[i];

                //הוספת הזוג הזמנה -מוצר לאוסף

                orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }
        private void ProductArrCountToForm(OrderProductArr curOrderproductArr)
        {
            listBox_InOrderProductsCount.Items.Clear();
            for (int i = 0; i < curOrderproductArr.Count; i++)
            {
                listBox_InOrderProductsCount.Items.Add(
                (curOrderproductArr[i] as OrderProduct).Count);
            }

            //כדי לסמן את השורה הראשונה ישר בהתחלה )אם יש כזאת(

            if (listBox_InOrderProductsCount.Items.Count > 0)
                listBox_InOrderProductsCount.SelectedIndex = 0;
        }


        //המרות לקוחות מהבי אל
        private void ClientArrToForm(ComboBox comboBox, bool isMustChoose, Client curClient = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();

            //הוספת לקוח ברירת מחדל - בחר לקוח
            //יצירת מופע חדש של לקוח עם מזהה מינוס 1 ושם מתאים

            Client clientDefault = new Client();
            clientDefault.Id = -1;

            if (isMustChoose)
            {
                clientDefault.FirstName = "Choose a client";
                clientDefault.LastName = "";
            }
            else
            {
                clientDefault.FirstName = "All clients";
                clientDefault.LastName = "";
            }

            clientArr.Add(clientDefault);
            clientArr.Fill();
            comboBox.DataSource = clientArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "";

            //הוספת הלקוח לאוסף הלקוחות - אותו נציב במקור הנתונים של תיבת הבחירה

            clientArr.Add(clientDefault);


            if (curClient != null)
            {
                comboBox_Client.SelectedValue = curClient.Id;
            }
        }
        private void ClientToForm(Client client)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס



            if (client != null)
            {
                label_IdClient.Text = client.Id.ToString();
                label_FirstNameClient.Text = client.FirstName;
                label_LastNameClient.Text = client.LastName;
                if (client.PhoneNumber > 999999999)
                {
                    label_PhoneNumberClient.Text = client.PhoneNumber.ToString();
                }
                else
                {
                    label_PhoneNumberClient.Text = "0" + client.PhoneNumber.ToString();
                }

                label_CityClient.Text = client.City.Name.ToString();

            }

            else
            {
                label_Id.Text = "";
                label_FirstNameClient.Text = "";
                label_LastNameClient.Text = "";
                label_PhoneNumberClient.Text = "";
                label_CityClient.Text = "";

            }
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

        //ליסט בוקס
        private void listBox_Orders_DoubleClick(object sender, EventArgs e)
        {
            Order order = listBox_Orders.SelectedItem as Order;
            OrderToForm(order);
            ClientToForm(order.Client);
            listBox_Clients.SelectedValue = order.Client.Id;

            ProductArr productArrInOrder = new ProductArr();
            OrderProductArr orderProductArr = new OrderProductArr();
            orderProductArr.Fill();

            //סינון לפי הזמנה נוכחית

            orderProductArr = orderProductArr.FilterOrder(order);

            //רק אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            productArrInOrder = orderProductArr.GetProductArr();
            ProductArrToForm(listBox_InOrderProducts, productArrInOrder);

            //תיבת רשימה - פריטים פוטנציאלים
            //כל הפריטים - פחות אלו שכבר נבחרו

            ProductArr productArrNotInOrder = new ProductArr();
            productArrNotInOrder.Fill();

            //הורדת הפריטים שכבר קיימים בהזמנה
            int y = productArrNotInOrder.Count;
            for (int i = 0; i < productArrInOrder.Count; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    if ((productArrNotInOrder[j] as Product).Id == (productArrInOrder[i] as Product).Id)
                    {
                        productArrNotInOrder.Remove(productArrNotInOrder[j] as Product);
                        y--;
                    }
                }
            }

            //productArrNotInOrder.Remove(productArrInOrder);
            ProductArrToForm(listBox_Products, productArrNotInOrder);
            ProductArrCountToForm(orderProductArr);
            PaymentToForm();
        }
        private void listBox_Products_DoubleClick(object sender, EventArgs e)
        {
            Product product = listBox_Products.SelectedItem as Product;
            MoveSelectedProductBetweenListBox(listBox_Products, listBox_InOrderProducts, true);
            PaymentToForm();
        }        
        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            Client client = listBox_Clients.SelectedItem as Client;
            ClientToForm(client);
        }
        private void listBox_InOrderProducts_Click(object sender, EventArgs e)
        {
            listBox_InOrderProductsCount.SelectedIndex = listBox_InOrderProducts.SelectedIndex;
        }
        private void listBox_InOrderProductsCount_Click(object sender, EventArgs e)
        {
            listBox_InOrderProducts.SelectedIndex = listBox_InOrderProductsCount.SelectedIndex;
        }
        private void MoveSelectedProductBetweenListBox(ListBox listBox_From, ListBox listBox_To, bool isToOrder)
        {
            ProductArr productArr = null;

            //מוצאים את הפריט הנבחר

            Product product = listBox_From.SelectedItem as Product;

            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים
            if (isToOrder)

            //ההעברה היא אל הרשימה של הפריטים בהזמנה

            {
                product.Count--;
                listBox_InOrderProductsCount.Items.Add(1);
            }
            else
            {
                product.Count += (int)listBox_InOrderProductsCount.SelectedItem;
                listBox_InOrderProductsCount.Items.RemoveAt(listBox_InOrderProductsCount.SelectedIndex);

            }

            if (listBox_To.DataSource != null)
                productArr = listBox_To.DataSource as ProductArr;
            else
                productArr = new ProductArr();
            productArr.Add(product);
            ProductArrToForm(listBox_To, productArr);
            ///הסרת הפריט הנבחר מרשימת הפריטים הנבחרים

            productArr = listBox_From.DataSource as ProductArr;
            productArr.Remove(product);
            ProductArrToForm(listBox_From, productArr);
            //אם זאת הוספה לתיבת המוצרים בהזמנה - סימון שתי השורה האחרונה בה וגם בתיבת הרשימה של הכמויות
            if (isToOrder)
            {
                int k = listBox_To.Items.Count - 1;
                listBox_To.SelectedIndex = k;
                listBox_InOrderProductsCount.SelectedIndex = k;
            }
        }


        //ניקוי טופס
        private void clear_Click(object sender, EventArgs e)
        {

            label_Id.Text = "0";
            richTextBox_Note.Text = "";
            dateTimePicker_Date.Value = DateTime.Now;
            ClientArrToForm(comboBox_Client, true);
            listBox_InOrderProducts.DataSource = null;
            listBox_InOrderProductsCount.Items.Clear();
            ProductArrToForm(listBox_Products);
            PaymentToForm();

        }
        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            ClientArrToForm(comboBox_ClientFilter, false);
            filterDate = false;
            dateTimePicker_FromDateFilter.Value = DateTime.Now;
            dateTimePicker_ToDateFilter.Value = DateTime.Now;
            OrderArrToForm();

        }
        private void button_ClearFilterClient_Click(object sender, EventArgs e)
        {
            textBox_IdFilterClient.Text = "";
            textBox_FirstNameFilterClient.Text = "";
            textBox_LastNameFilterClient.Text = "";
            textBox_PhoneNumberFilterClient.Text = "";
            ClientArrToForm();
        }
        private void button_ClearFilterProduct_Click(object sender, EventArgs e)
        {
            textBox_IdFilterProduct.Text = "";
            CategoryArrToForm(comboBox_CategoryFilterProduct, false);
            textBox_NameFilterProduct.Text = "";
            ArtistArrToForm(comboBox_ArtistFilterProduct, false);
        }




        //מחיקה
        private void button_Delete_Click(object sender, EventArgs e)
        {
            Order order = FormToOrder();
            if (order.Id == 0)
            {
                MessageBox.Show("You need to choose a order");
            }
            else

            {

                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {

                    OrderProductArr orderProductArr_Old = new OrderProductArr();
                    orderProductArr_Old.Fill();

                    //סינון לפי ההזמנה הנוכחית

                    orderProductArr_Old = orderProductArr_Old.FilterOrder(order);

                    //מחיקת כל הפריטים באוסף ההזמנה-פריט של ההזמנה הנוכחית

                    if (orderProductArr_Old.Delete() &&
                    order.Delete())
                    {
                        MessageBox.Show("Deleted");
                    }


                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                    OrderToForm(null);
                    OrderArrToForm();

                    label_Id.Text = "0";
                    richTextBox_Note.Text = "";
                    dateTimePicker_Date.Value = DateTime.Now;
                    ClientArrToForm(comboBox_Client, true);
                    listBox_InOrderProducts.DataSource = null;
                    listBox_InOrderProductsCount.Items.Clear();
                    ProductArrToForm(listBox_Products);
                    PaymentToForm();
                }
            }
        }



        //פילטר הזמנות
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetOrdersByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_ClientFilter.SelectedItem as Client != null)
            {
                SetOrdersByFilter();
            }

        }
        private void dateTimePicker_Filter_MouseCaptureChanged(object sender, EventArgs e)
        {
            filterDate = true;
        }
        private void dateTimePicker_DateFilter_ValueChanged(object sender, EventArgs e)
        {
            if (filterDate)
            {
                SetOrdersByFilter();
            }
        }
        private void SetOrdersByFilter()
        {
            int id = 0;
            //מייצרים אוסף של כלל המוצרים
            if (textBox_IdFilter.Text != "")
                id = int.Parse(textBox_IdFilter.Text);

            DateTime fromDate = DateTime.MinValue;
            DateTime toDate = DateTime.MaxValue;
            if (filterDate)
            {
                fromDate = dateTimePicker_FromDateFilter.Value;
                toDate = dateTimePicker_ToDateFilter.Value;
            }


            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            orderArr = orderArr.Filter(id,
            comboBox_ClientFilter.SelectedItem as Client,
            fromDate,
            toDate
            );

            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_Orders.DataSource = orderArr;
        }

        //פילטר מוצרים
        private void textBox_FilterProduct_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }
        private void comboBoxFilterProduct_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_CategoryFilterProduct.SelectedItem as Category != null &&
                comboBox_ArtistFilterProduct.SelectedItem as Artist != null)
            {
                SetProductsByFilter();
            }
        }
        private void SetProductsByFilter()
        {
            int id = 0;
            //מייצרים אוסף של כלל המוצרים
            if (textBox_IdFilterProduct.Text != "")
            {
                id = int.Parse(textBox_IdFilterProduct.Text);
            }

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(id,
            textBox_NameFilterProduct.Text,
            comboBox_CategoryFilterProduct.SelectedItem as Category,
            comboBox_ArtistFilterProduct.SelectedItem as Artist
            );

            if (listBox_InOrderProducts.DataSource != null)
                productArr.Remove(listBox_InOrderProducts.DataSource as ProductArr);

            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_Products.DataSource = productArr;
            filterDate = false;
        }

        //פילטר לקוחות
        private void textBox_FilterClient_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_IdFilterClient.Text != "")
            {
                id = int.Parse(textBox_IdFilterClient.Text);
            }

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש
            clientArr = clientArr.Filter(id, textBox_FirstNameFilterClient.Text, textBox_LastNameFilterClient.Text,
            textBox_PhoneNumberFilterClient.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;


        }


        //פתיחת טפסים אחרים
        private void button_AddClient_Click(object sender, EventArgs e)
        {
            Form_Client form_Client = new Form_Client();
            form_Client.ShowDialog();
            ClientArrToForm(comboBox_Client, true, form_Client.SelectedClient);
        }
        private void button_OrderReport_Click(object sender, EventArgs e)
        {
            Form_OrderReport form_OrderReport = new Form_OrderReport();
            form_OrderReport.ShowDialog();
        }


        //הוספה והפחתה של מוצרים
        private void button_Plus_Click(object sender, EventArgs e)
        {

            //הגדלת הכמות של המוצר בהזמנה באחד
            //אם לא מסומנת השורה של הכמויות

            if (listBox_InOrderProductsCount.SelectedIndex >= 0)
            {
                //בדיקה האם יש במלאי לפחות 1

                if ((listBox_InOrderProducts.SelectedItem as Product).Count > 0)

                //אם כן, הוספה לכמות של פריט-הזמנה והורדה מהמלאי

                {

                    //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה

                    int k = listBox_InOrderProductsCount.SelectedIndex;
                    listBox_InOrderProductsCount.Items[k] =
                    (int)listBox_InOrderProductsCount.Items[k] + 1;

                    //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                    ProductArr productArr = listBox_InOrderProducts.DataSource as ProductArr;
                    Product product = listBox_InOrderProducts.SelectedItem as Product;
                    product.Count--;
                    productArr.UpdateProduct(product);
                    ProductArrToForm(listBox_InOrderProducts, productArr);
                    PaymentToForm();
                }
            }
            //אם לא הודעה מתאימה

            else
            {
                MessageBox.Show("choose an item");
            }
        }
        private void button_Minus_Click(object sender, EventArgs e)
        {

            //הגדלת הכמות של המוצר בהזמנה באחד
            //אם לא מסומנת השורה של הכמויות

            if (listBox_InOrderProductsCount.SelectedIndex >= 0)
            {
                //בדיקה האם יש במלאי לפחות 1

                if (int.Parse(listBox_InOrderProductsCount.SelectedItem.ToString()) > 0)

                //אם כן, הוספה לכמות של פריט-הזמנה והורדה מהמלאי

                {

                    //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה

                    int k = listBox_InOrderProductsCount.SelectedIndex;
                    listBox_InOrderProductsCount.Items[k] =
                    (int)listBox_InOrderProductsCount.Items[k] - 1;

                    //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                    ProductArr productArr = listBox_InOrderProducts.DataSource as ProductArr;
                    Product product = listBox_InOrderProducts.SelectedItem as Product;
                    product.Count++;
                    productArr.UpdateProduct(product);
                    ProductArrToForm(listBox_InOrderProducts, productArr);

                    PaymentToForm();
                }

                else
                {
                    MoveSelectedProductBetweenListBox(listBox_InOrderProducts, listBox_Products, false);
                }
            }
            //אם לא הודעה מתאימה

            else
            {
                MessageBox.Show("choose an item");
            }

        }

        //חישוב תשלום
        private void PaymentToForm()
        {
            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            OrderProductArr inOrderProductArr = new OrderProductArr();
            inOrderProductArr = FormToOrderProductArr();
            int payment = 0;
            if (inOrderProductArr != null)
            {
                for (int i = 0; i < inOrderProductArr.Count; i++)
                {
                    payment += (inOrderProductArr[i] as OrderProduct).Product.Price * (inOrderProductArr[i] as OrderProduct).Count;
                }
            }

            label_Payment.Text = payment.ToString()+ "₪";
            
        }
    }
}
