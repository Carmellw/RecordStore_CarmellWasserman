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
    public partial class Form_ProductReport : Form
    {
        private Bitmap m_bitmap;
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;
        public Form_ProductReport()
        {
            InitializeComponent();
            FillListView();
            CategoryArrToForm(comboBox_CategoryFilter, false);
            ArtistArrToForm(comboBox_ArtistFilter, false);

        }

        private void FillListView()
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            ProductArr productArr = new ProductArr();
            productArr.Fill();
            Product p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < productArr.Count; i++)
            {
                p = productArr[i] as Product;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.Category.Name,

                p.Name, p.Artist.Name, p.Count.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Products.Items.Add(listViewItem);
            }
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 100, 100);
        }

        /*/private void CaptureScreen()
        {

            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            int addAboveListView = 30;
            int moveLeft = 150;
            Graphics graphics = listView_Products.CreateGraphics();
            Size curSize = new Size(listView_Products.Width*3,listView_Products.Height*2);
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(listView_Products.Location);
            graphics.CopyFromScreen(2*panelLocation.X, 2*(panelLocation.Y - addAboveListView),
            moveLeft, 0, curSize);
        }/*/
        private void CaptureScreen()
        {

            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            int addAboveListView = 30;
            int moveLeft = 0;
            Graphics graphics = listView_Products.CreateGraphics();
            Size curSize = new Size(listView_Products.Width * 3, listView_Products.Height * 2);
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(listView_Products.Location);
            graphics.CopyFromScreen(2*panelLocation.X, 2*panelLocation.Y - addAboveListView,
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
            SetProductsByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_CategoryFilter.SelectedItem as Category != null &&
                comboBox_ArtistFilter.SelectedItem as Artist != null ||
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

            listView_Products.Items.Clear();
            Product p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < productArr.Count; i++)
            {
                p = productArr[i] as Product;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] {  p.Category.Name,

                p.Name, p.Artist.Name, p.Count.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה


                listView_Products.Items.Add(listViewItem);
            }
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
        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            CategoryArrToForm(comboBox_CategoryFilter, false);
            textBox_NameFilter.Text = "";
            ArtistArrToForm(comboBox_ArtistFilter, false);
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
                comboBox.SelectedValue = curCategory.Id;
            }
        }

        /*/private void GenreArrToForm(ComboBox comboBox, bool isMustChoose, Genre curGenre = null)
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
        }/*/

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
                comboBox.SelectedValue = curArtist.Id;
            }
        }

        /*/private void CompanyArrToForm(ComboBox comboBox, bool isMustChoose, Company curCompany = null)
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
        }/*/

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
    }
}

       

        