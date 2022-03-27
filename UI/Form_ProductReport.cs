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
    public partial class Form_ProductReport : Form
    {
        private Bitmap m_bitmap;
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;
        public Form_ProductReport()
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            FillListView();
            CategoryArrToForm(comboBox_CategoryFilter, false);
            ArtistArrToForm(comboBox_ArtistFilter, false);
            DateToListView();
            DataToChart(0, chart1);
            DataToChart(1, chart2);
            DataToChart(2, chart3);



        }


        //הגבלת בכנסת פרטים
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


        //הדפסה
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 0, 0, this.Width + 2*this.Width/5, this.Height + 2*this.Height/5);
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


        //דוחות רשימה
        private void FillListView()
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            ProductArr productArr = new ProductArr();
            productArr.Fill();
            Product p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            //for (int i = 0; i < productArr.Count; i++)
            {
                p = productArr[1] as Product;
                string condition = "not new";
                if(p.IsNew)
                {
                    condition = "new";
                }
                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.Category.Name,

                p.Name, p.Genre.Name, p.Artist.Name, p.Company.Name, condition, p.Count.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Products.Items.Add(listViewItem);
            }
        }
        private void listView_Products_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Products.ListViewItemSorter = sorter;
            sorter = listView_Products.ListViewItemSorter as ListViewSorter;
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
            listView_Products.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }
        private void listView_Records_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Records.ListViewItemSorter = sorter;
            sorter = listView_Records.ListViewItemSorter as ListViewSorter;
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
            listView_Records.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }
        private void DateToListView()
        {
            OrderProductArr curOrderProductArr = new OrderProductArr();
            curOrderProductArr.Fill();
            Dictionary<string, int> dictionary = curOrderProductArr.GetDictionaryRecord();

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            ListViewItem listViewItem;
            foreach (KeyValuePair<string, int> item in dictionary)
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                listView_Records.Items.Add(listViewItem);
            }
        }


        //פילטר
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_CategoryFilter.SelectedItem as Category != null &&
                comboBox_ArtistFilter.SelectedItem as Artist != null )
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

            listView_Products.Items.Clear();
            Product p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < productArr.Count; i++)
            {
                p = productArr[i] as Product;
                string condition = "not new";
                if (p.IsNew)
                {
                    condition = "new";
                }
                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] {  p.Category.Name,

                p.Name, p.Genre.Name, p.Artist.Name, p.Company.Name, condition, p.Count.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה


                listView_Products.Items.Add(listViewItem);
            }
        }


        //ניקוי טופס
        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            CategoryArrToForm(comboBox_CategoryFilter, false);
            textBox_NameFilter.Text = "";
            ArtistArrToForm(comboBox_ArtistFilter, false);
            FillListView();
        }



        //המרות של תכונות של מוצר מהבי אל
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
                comboBox.SelectedValue = curCategory.Id;
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
                artistDefault.Name = "All artists";
            artistArr.Add(artistDefault);
            artistArr.Fill();
            comboBox.DataSource = artistArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            artistArr.Add(artistDefault);


            if (curArtist != null)
            {
                comboBox.SelectedValue = curArtist.Id;
            }
        }


        //דוחות גרף
        public void DataToChart(int i, Chart chart)
        {
            chart.Palette = ChartColorPalette.Fire;
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart.Titles.Clear();
            if (i == 0)
            {
                chart.Titles.Add("Distribution of Product Categories");
            }
            else if(i==1)
            {
                chart.Titles.Add("Distribution of Product Genres");

            }
            else if(i==2)
            {
                chart.Titles.Add("Distribution of Product Condition");

            }
            ProductArr curProductArr = new ProductArr();
            curProductArr.Fill();
            SortedDictionary<string, int> dictionary = curProductArr.GetSortedDictionary(i);

            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series = new Series("Distribution");

            //סוג הגרף

            series.ChartType = SeriesChartType.Pie;

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

    }
}

       

        