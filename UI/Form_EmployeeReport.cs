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
        public Form_EmployeeReport()
        {
            InitializeComponent();
            FillListView();
            FillListViewPassword();
            FillListViewPayment();
            EmployeeArrToForm(comboBox_Employees, true);
        }

        private void FillListView()
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
                listView1.Items.Add(listViewItem);
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
                listView2.Items.Add(listViewItem);
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
    }
}
