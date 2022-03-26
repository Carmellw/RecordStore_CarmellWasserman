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
using System.Windows.Forms.DataVisualization.Charting;


namespace RecordStore_CarmellWasserman.UI
{
    public partial class Form_OrderReport : Form
    {
        private Bitmap m_bitmap;
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;
        private bool filterDate = false;
        public Form_OrderReport()
        {
            InitializeComponent();
            FillListView();
            DataToChart(0, chart1);
            DataToChart(1, chart2);
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            ClientArrToForm(comboBox_ClientFilter, false);

        }

        private void FillListView()
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            Order p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < orderArr.Count; i++)
            {
                p = orderArr[i] as Order;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.Client.ToString(),

                p.Date.ToString(), p.Note });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Orders.Items.Add(listViewItem);
            }
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 0, 0, this.Width + 2 * this.Width / 5, this.Height + 2 * this.Height / 5);
        }
        private void CaptureScreen()
        {

            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            int addAboveListView = 0;
            int moveLeft = 0;
            Graphics graphics = this.CreateGraphics();
            Size curSize = new Size(this.Width * 2 - 50, this.Height * 2 - 75);
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(this.Location);
            graphics.CopyFromScreen(panelLocation.X + 20, panelLocation.Y + 25,
            moveLeft, -150, curSize);
        }




        private void button_Print_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Width = 600; printPreviewDialog1.Height = 800;
            printPreviewDialog1.ShowDialog();
        }

     

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_Heb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.KeyChar = char.MinValue;
            }

        }
        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            ClientArrToForm(comboBox_ClientFilter, false);
            filterDate = false;
            dateTimePicker_FromDateFilter.Value = DateTime.Now;
            dateTimePicker_ToDateFilter.Value = DateTime.Now;
            FillListView();
        }

        private void listView_Orders_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Orders.ListViewItemSorter = sorter;
            sorter = listView_Orders.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = e.Column;

            // אם לחצו שוב על אותה עמודה - המיון יהיה בסדר הפוך לקודם

            if (m_LastColumnSortBy == e.Column)
                if (m_LastSortOrder == SortOrder.Ascending)
                    sorter.SortOrder = SortOrder.Descending;
                else
                    sorter.SortOrder = SortOrder.Ascending;

            // אחרת - זוהי עמודה חדשה - המיון יהיה בסדר עולה

            else
                sorter.SortOrder = SortOrder.Ascending;
            listView_Orders.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }

        public void DataToChart(int i, Chart chart)
        {
            chart.Palette = ChartColorPalette.Fire;
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart.Titles.Clear();
            

            OrderArr curOrderArr = new OrderArr();
            curOrderArr.Fill();
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();

            if (i == 0)
            {
                chart.Titles.Add("Distribution of Order by Month");
                dictionary = curOrderArr.GetSortedDictionary(DateTime.Now.Year);

            }
            else if (i == 1)
            {
                chart.Titles.Add("Distribution of Order by Day");
                dictionary = curOrderArr.GetSortedDictionary();

            }

            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series = new Series("Distribution");

            //סוג הגרף

            series.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3

            Font SmallFont = new Font("Arial", 7);
            series.Font = SmallFont;
            series.Label = "#VALX [#VAL = #PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);
            //מחיקת סדרות קיימות - אם יש ולא בכוונה

            chart.Series.Clear();

            //הוספת הסדרה לפקד הגרף

            chart.Series.Add(series);
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetOrdersByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_ClientFilter.SelectedItem as Client != null &&
                (comboBox_ClientFilter.SelectedItem as Client).Id > 0)
            {
                SetOrdersByFilter();
            }

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
            listView_Orders.Items.Clear();
            Order p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < orderArr.Count; i++)
            {
                p = orderArr[i] as Order;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.Client.ToString(),

                p.Date.ToString(), p.Note });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Orders.Items.Add(listViewItem);

            }
        }

        private void dateTimePicker_Filter_MouseCaptureChanged(object sender, EventArgs e)
        {
            filterDate = true;
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
                clientDefault.FirstName = "All clients";
                clientDefault.LastName = "";
            }

            clientArr.Add(clientDefault);
            clientArr.Fill();
            comboBox.DataSource = clientArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "";

            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            clientArr.Add(clientDefault);



        }





    }
}



