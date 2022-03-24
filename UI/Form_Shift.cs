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
    public partial class Form_Shift : Form
    {
        private Label[,] shifts = new Label[7, 2];
        public Form_Shift()
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            //label_DateToday.Text = ((int)DateTime.Now.DayOfWeek).ToString();
        }
        /*/public void Setarr()
        {
            shifts[0,0] = label_SundayEvening;
            shifts[0,1] = label_SundayMorning;
            shifts[1,0] = label_MondayEvening;
            shifts[1,1] = label_MondayMorning;
            shifts[2, 0] = label_TuesdayEvening;
            shifts[2, 1] = label_TuesdayMorning;
            shifts[3, 0] = label_WednesdayEvening;
            shifts[3, 1] = label_WednesdayMorning;
            shifts[4, 0] = label_ThursdayEvening;
            shifts[4, 1] = label_ThursdayMorning;
            shifts[5, 0] = label_FridayEvening;
            shifts[5, 1] = label_FridayMorning;
            shifts[6, 0] = label_SaturdayEvening;
            shifts[6, 1] = label_SaturdayMorning;
           
        }/*/

        private void label_Shift_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;


            string labelName = label.Name;



            bool time = Convert.ToBoolean(int.Parse(labelName.Substring(labelName.Length - 1)));
            int day = int.Parse(Char.ToString(labelName[labelName.Length - 2]));

            DateTime dateTime = DateTime.Today.AddDays(day - (int)DateTime.Now.DayOfWeek);

            ShiftArr shiftArr = new ShiftArr();
            shiftArr.Fill();

            if(shiftArr.DoesExist(dateTime, time))
            {
                //update
            }
            else
            {
                //add
            }
        }

        /*/
         צריך לעשות את המספרים למעלה והכנסה של משמרות קיימות 
        ShiftArrToForm

        ליצור יואי של עריכת משמרת 
         
         
        /*/

    }
}
