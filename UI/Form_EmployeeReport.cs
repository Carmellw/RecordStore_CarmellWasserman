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
    public partial class Form_EmployeeReport : Form
    {
        private Bitmap m_bitmap;
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;
        public Form_EmployeeReport()
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            FillListView();
            FillListViewPassword();
            FillListViewPayment();
            EmployeeArrToForm(comboBox_Employees, true);
        }

        private void FillListView()
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים
            listView_Employees.Items.Clear();
            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();
            Employee p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < employeeArr.Count; i++)
            {
                p = employeeArr[i] as Employee;

                string digit = "";
                if(p.PhoneNumber < 1000000000)
                {
                    digit = "0";
                }

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.LastName,

                p.FirstName,digit+ p.PhoneNumber.ToString(), p.Email });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Employees.Items.Add(listViewItem);
            }
        }

        private void FillListViewPassword()
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();
            Employee p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < employeeArr.Count; i++)
            {
                p = employeeArr[i] as Employee;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.LastName,

                p.FirstName, p.Username, p.Password });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_EmployeesPassword.Items.Add(listViewItem);
            }
        }

        private void FillListViewPayment()
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();
            ShiftEmployeeArr shiftEmployeeArr = new ShiftEmployeeArr();
            Employee p;
            ListViewItem listViewItem;
            int shifts;
            

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < employeeArr.Count; i++)
            {
                p = employeeArr[i] as Employee;
                shiftEmployeeArr.Fill();
                shifts = shiftEmployeeArr.FilterEmployee(p).FilterMonth(DateTime.Now.Month).Count;


                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.LastName,

                p.FirstName, shifts.ToString() , (shifts* p.HourlyWage).ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_EmployeesPayment.Items.Add(listViewItem);
            }
        }

        public void DataToChart(Employee employee, Chart chart)
        {
            if (employee.Id != -1)
            {
                chart.Palette = ChartColorPalette.Fire;
                chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                chart.Titles.Clear();


                ShiftEmployeeArr curShiftEmployeeArr = new ShiftEmployeeArr();
                curShiftEmployeeArr.Fill();
                SortedDictionary<string, int> dictionary = curShiftEmployeeArr.GetSortedDictionary(employee);
                chart.Titles.Add("Distribution of " + employee.ToString() + "'s Shifts");


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

        private void EmployeeArrToForm(ComboBox comboBox, bool isMustChoose)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            EmployeeArr employeeArr = new EmployeeArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Employee employeeDefault = new Employee();
            employeeDefault.Id = -1;

            if (isMustChoose)
            {
                employeeDefault.LastName = "Choose a employee";
                employeeDefault.FirstName = "";
            }
            else
            {
                employeeDefault.LastName = "All employees";
                employeeDefault.FirstName = "";

            }

            employeeArr.Add(employeeDefault);
            employeeArr.Fill();
            comboBox.DataSource = employeeArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "";

            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            employeeArr.Add(employeeDefault);





        }

        private void comboBox_Employees_TextChanged(object sender, EventArgs e)
        {
            DataToChart(comboBox_Employees.SelectedItem as Employee, chart1);
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

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_IdFilter.Text != "")
                id = int.Parse(textBox_IdFilter.Text);

            //מייצרים אוסף של כלל הלקוחות

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            employeeArr = employeeArr.Filter(id, textBox_FirstNameFilter.Text, textBox_LastNameFilter.Text,
            textBox_PhoneNumberFilter.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            Employee p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < employeeArr.Count; i++)
            {
                p = employeeArr[i] as Employee;

                string digit = "";
                if (p.PhoneNumber < 1000000000)
                {
                    digit = "0";
                }

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.LastName,

                p.FirstName,digit+ p.PhoneNumber.ToString(), p.Email });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Employees.Items.Add(listViewItem);
            }
        }

        private void button_ClearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            textBox_FirstNameFilter.Text = "";
            textBox_LastNameFilter.Text = "";
            textBox_PhoneNumberFilter.Text = "";
            FillListView();
        }

        private void textBox_FilterPassword_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_IdFilterPassword.Text != "")
                id = int.Parse(textBox_IdFilterPassword.Text);

            //מייצרים אוסף של כלל הלקוחות

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            employeeArr = employeeArr.Filter(id, textBox_FirstNameFilterPassword.Text, textBox_LastNameFilterPassword.Text,
            textBox_PhoneNumberFilterPassword.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            Employee p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < employeeArr.Count; i++)
            {
                p = employeeArr[i] as Employee;

                string digit = "";
                if (p.PhoneNumber < 1000000000)
                {
                    digit = "0";
                }

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.LastName,

                p.FirstName,digit+ p.PhoneNumber.ToString(), p.Email });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Employees.Items.Add(listViewItem);
            }
        }

        private void button_ClearFilterPassword_Click(object sender, EventArgs e)
        {
            textBox_IdFilterPassword.Text = "";
            textBox_FirstNameFilterPassword.Text = "";
            textBox_LastNameFilterPassword.Text = "";
            textBox_PhoneNumberFilterPassword.Text = "";
            FillListViewPassword();
        }

        private void textBox_FilterPayment_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_IdFilterPayment.Text != "")
                id = int.Parse(textBox_IdFilterPayment.Text);

            //מייצרים אוסף של כלל הלקוחות

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            employeeArr = employeeArr.Filter(id, textBox_FirstNameFilterPayment.Text, textBox_LastNameFilterPayment.Text,
            textBox_PhoneNumberFilterPayment.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            Employee p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < employeeArr.Count; i++)
            {
                p = employeeArr[i] as Employee;

                string digit = "";
                if (p.PhoneNumber < 1000000000)
                {
                    digit = "0";
                }

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.LastName,

                p.FirstName,digit+ p.PhoneNumber.ToString(), p.Email });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Employees.Items.Add(listViewItem);
            }
        }

        private void button_ClearFilterPayment_Click(object sender, EventArgs e)
        {
            textBox_IdFilterPayment.Text = "";
            textBox_FirstNameFilterPayment.Text = "";
            textBox_LastNameFilterPayment.Text = "";
            textBox_PhoneNumberFilterPayment.Text = "";
            FillListViewPayment();
        }

        private void listView_Employees_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Employees.ListViewItemSorter = sorter;
            sorter = listView_Employees.ListViewItemSorter as ListViewSorter;
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
            listView_Employees.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }

        private void listView_EmployeesPassword_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_EmployeesPassword.ListViewItemSorter = sorter;
            sorter = listView_EmployeesPassword.ListViewItemSorter as ListViewSorter;
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
            listView_EmployeesPassword.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }

        private void listView_EmployeesPayment_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_EmployeesPayment.ListViewItemSorter = sorter;
            sorter = listView_EmployeesPayment.ListViewItemSorter as ListViewSorter;
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
            listView_EmployeesPayment.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
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

    }

}
