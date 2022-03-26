using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RecordStore_CarmellWasserman.BL;

namespace RecordStore_CarmellWasserman.UI
{
    public partial class Form_ClientReport : Form
    {
        public Form_ClientReport()
        {
            InitializeComponent();
            DataToChart();
            DateToListView();
        }

        public void DataToChart()
        {
            chart1.Palette = ChartColorPalette.Fire;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution of customers by locality");
            ClientArr curClientArr = new ClientArr();
            curClientArr.Fill();
            SortedDictionary<string, int> dictionary = curClientArr.GetSortedDictionary();

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

            chart1.Series.Clear();

            //הוספת הסדרה לפקד הגרף

            chart1.Series.Add(series);
         }

       
        private void DateToListView()
        {
            OrderArr curOrderArr = new OrderArr();
            curOrderArr.Fill();
            Dictionary<string, int> dictionary = curOrderArr.GetDictionaryClient();

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            ListViewItem listViewItem;
            foreach (KeyValuePair<string, int> item in dictionary)
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                listView1.Items.Add(listViewItem);
            }
        }
        


    }
}
