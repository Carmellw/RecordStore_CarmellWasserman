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
        private Label[,] shifts = new Label[7, 2]; //מערך של כל המשמרות בטבלה
        private DateTime m_Sunday = new DateTime();//יום ראשון בשבוע המוצג בטבלה
        private Bitmap m_bitmap; 
        public Form_Shift()
        {
            InitializeComponent();
            label_DateToday.Text = DateTime.Now.ToLongDateString();
            //label_DateToday.Text = "a" + Environment.NewLine + "a";
            Setarr();
            m_Sunday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            ShiftArrToForm(m_Sunday);
        }

        //מערך של כל המשמרות בטבלה
        public void Setarr()
        {
            shifts[0,0] = label_SundayEvening00;
            shifts[0,1] = label_SundayMorning01;
            shifts[1,0] = label_MondayEvening10;
            shifts[1,1] = label_MondayMorning11;
            shifts[2, 0] = label_TuesdayEvening20;
            shifts[2, 1] = label_TuesdayMorning21;
            shifts[3, 0] = label_WednesdayEvening30;
            shifts[3, 1] = label_WednesdayMorning31;
            shifts[4, 0] = label_ThursdayEvening40;
            shifts[4, 1] = label_ThursdayMorning41;
            shifts[5, 0] = label_FridayEvening50;
            shifts[5, 1] = label_FridayMorning51;
            shifts[6, 0] = label_SaturdayEvening60;
            shifts[6, 1] = label_SaturdayMorning61;
           
        }


        //לחיצה על משמרת
        private void label_Shift_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;

            //איזו משמרת נלחצה
            string labelName = label.Name;
            bool time = Convert.ToBoolean(int.Parse(labelName.Substring(labelName.Length - 1)));
            int day = int.Parse(Char.ToString(labelName[labelName.Length - 2]));
            DateTime dateTime = m_Sunday.AddDays(day);

            //האם המשמרת קיימת כבר
            ShiftArr shiftArr = new ShiftArr();
            shiftArr.Fill();

            if(shiftArr.DoesExist(dateTime, time)) //כן- לעדכן
            {
                Shift shift = shiftArr.GetShiftId(dateTime, time);
                Form_ShiftAdd form_ShiftAdd = new Form_ShiftAdd(shift, false);
                form_ShiftAdd.ShowDialog();
            }
            else// לא- ליצור אחת חדשה
            {
                Shift shift = new Shift();
                shift.Date = dateTime;
                shift.IsMorning = Convert.ToBoolean(time);
                Form_ShiftAdd form_ShiftAdd = new Form_ShiftAdd(shift, true);
                form_ShiftAdd.ShowDialog();
            }

            ShiftArrToForm(m_Sunday);//עדכן משמרות
        }


        //הכנסת משמרות לטופס
        private void ShiftArrToForm(DateTime sunday)
        {
            DateToForm(sunday);
            ShiftArr shiftArr = new ShiftArr();
            Shift shift = new Shift();
            shiftArr.Fill();
            for (int i = 0; i < shifts.GetLength(0); i++)
            {
                for (int j = 0; j < shifts.GetLength(1); j++)
                {
          
                    if(shiftArr.DoesExist(m_Sunday.AddDays(i),Convert.ToBoolean(j)))
                    {
                        
                        EmployeeArr employeeArrInShift = new EmployeeArr();
                        ShiftEmployeeArr shiftEmployeeArr = new ShiftEmployeeArr();
                        shiftEmployeeArr.Fill();

                        
                        shift = shiftArr.GetShiftId(m_Sunday.AddDays(i), Convert.ToBoolean(j));
                        shiftEmployeeArr = shiftEmployeeArr.FilterShift(shift);
                        employeeArrInShift = shiftEmployeeArr.GetEmployeeArr();
                        EmployeeArrToForm(shifts[i,j],employeeArrInShift);
                    }

                    else
                    {
                        shifts[i, j].Text = "";
                    }

                }

            }
        } 
        private void DateToForm(DateTime sunday)
        {
            label_Sunday.Text = sunday.Day.ToString();
            label_Monday.Text = sunday.AddDays(1).Day.ToString();
            label_Tuesday.Text = sunday.AddDays(2).Day.ToString();
            label_Wednesday.Text = sunday.AddDays(3).Day.ToString();
            label_Thursday.Text = sunday.AddDays(4).Day.ToString();
            label_Friday.Text = sunday.AddDays(5).Day.ToString();
            label_Saturday.Text = sunday.AddDays(6).Day.ToString();

            label_StoreName.Text = "SHIFTS- " + sunday.Month.ToString();
            if(sunday.Month != sunday.AddDays(6).Month)
            {
                label_StoreName.Text += "/" + sunday.AddDays(6).Month.ToString();
            }
        } //הכנס תאריכים לטבלה
        private void EmployeeArrToForm(Label label, EmployeeArr employeeArr)
        {
            string employees = "";
            for (int i = 0; i < employeeArr.Count; i++)
            {
                employees += (employeeArr[i] as Employee).FirstName + " " +
                    (employeeArr[i] as Employee).LastName + Environment.NewLine + Environment.NewLine;

            }

            label.Text = employees;
        } //הכנסת עובדים למשמרת בטבלה


        //כפתורי קדימה ואחורה
        private void button_Future_Click(object sender, EventArgs e)
        {
            m_Sunday = m_Sunday.AddDays(7);
            ShiftArrToForm(m_Sunday);
        }
        private void button_Past_Click(object sender, EventArgs e)
        {
            m_Sunday = m_Sunday.AddDays(-7);
            ShiftArrToForm(m_Sunday);
        }


        //הדפסה
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 10, 10, this.Width+75, this.Height+50 );
        }
        private void CaptureScreen()
        {

            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            int addAboveListView = 30;
            int moveLeft = 0;
            Graphics graphics = this.CreateGraphics();
            Size curSize = new Size(this.Width*2-40, this.Height*2-190);
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(this.Location);
            graphics.CopyFromScreen(panelLocation.X+10, panelLocation.Y+25,
            moveLeft, 0, curSize);
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
