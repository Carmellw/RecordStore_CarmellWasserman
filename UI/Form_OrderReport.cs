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
        public Form_OrderReport()
        {
            InitializeComponent();
            FillListView();
            DataToChart(0, chart1);
            DataToChart(1, chart2);


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

            e.Graphics.DrawImage(m_bitmap, 0, 0, listView_Orders.Width * 2, listView_Orders.Height * 2);
        }
        private void CaptureScreen()
        {

            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            int addAboveListView = 30;
            int moveLeft = 0;
            Graphics graphics = listView_Orders.CreateGraphics();
            Size curSize = new Size(listView_Orders.Width * 2, listView_Orders.Height * 2);
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(listView_Orders.Location);
            graphics.CopyFromScreen(2 * panelLocation.X, 2 * panelLocation.Y - addAboveListView,
            moveLeft, 0, curSize);
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Width = 600; printPreviewDialog1.Height = 800;
            printPreviewDialog1.ShowDialog();
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetOrdersByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {

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

            //orderArr = orderArr.Filter(id,
            //textBox_NameFilter.Text,
            //comboBox_CategoryFilter.SelectedItem as Category,
            //comboBox_ArtistFilter.SelectedItem as Artist
            //);

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




        private void button_ClearFilter_Click(object sender, EventArgs e)
        {

        }
    }
}



