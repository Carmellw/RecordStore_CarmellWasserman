﻿using System;
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
    public partial class Form_ShiftAdd : Form
    {
        private Shift m_Shift;
        public Form_ShiftAdd(Shift shift, bool isNew)
        {
            InitializeComponent();
            EmployeeArrToForm(listBox_Employees);
            m_Shift = shift;
            if(!isNew) //אם זו לא משמרת חדשה
            {
                label_Id.Text = shift.Id.ToString();
            }
            ShiftToForm(shift);
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
                Shift shift = m_Shift;
                ShiftEmployeeArr shiftEmployeeArr_New;

                if (label_Id.Text == "0")
                {
                    if (shift.Insert())
                    {
                        ShiftArr shiftArr = new ShiftArr();
                        shiftArr.Fill();
                        shift = shiftArr.GetShiftWithMaxId();
                        shiftEmployeeArr_New = FormToShiftEmployeeArr(shift);

                        //מוסיפים את הפריטים החדשים למשמרת

                        if (shiftEmployeeArr_New.Insert())
                        {
                            MessageBox.Show("Successfully saved");
                            //מעדכנים את מלאי הפריטים שהוזמנו

                            ;
                        }
                        else
                            MessageBox.Show("Error in insert");
                    }
                }

                else
                {


                    //מוחקים את הפריטים הקודמים של המשמרת
                    //אוסף כלל הזוגות - משמרת-פריט

                    ShiftEmployeeArr shiftEmployeeArr_Old = new ShiftEmployeeArr();
                    shiftEmployeeArr_Old.Fill();

                    //סינון לפי המשמרת הנוכחית

                    shiftEmployeeArr_Old = shiftEmployeeArr_Old.FilterShift(shift);

                    //מחיקת כל הפריטים באוסף המשמרת-פריט של המשמרת הנוכחית

                    shiftEmployeeArr_Old.Delete();

                    //מוסיפים את הפריטים לפי העדכני למשמרת

                    shiftEmployeeArr_New = FormToShiftEmployeeArr(shift);
                    shiftEmployeeArr_New.Insert();
                    //מעדכנים את מלאי הפריטים, אלו שהוזמנו ואלו שבפוטנציאל



                }

            }
        }
        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            if (listBox_InShiftEmployees.Items.Count == 0)
            {
                flag = false;
                MessageBox.Show("choose items");
            }





            return flag;
        }


        //המרות עובדים מהבי אל
        private void EmployeeArrToForm(ListBox listBox, EmployeeArr employeeArr = null)
        {

            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (employeeArr == null)
            {
                employeeArr = new EmployeeArr();
                employeeArr.Fill();
            }
            listBox.DataSource = employeeArr;
        }


        //ליסט בוקס
        private void MoveSelectedEmployeeBetweenListBox(ListBox listBox_From, ListBox listBox_To, bool isToShift)
        {
            EmployeeArr employeeArr = null;

            //מוצאים את הפריט הנבחר

            Employee employee = listBox_From.SelectedItem as Employee;

            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים
          



            if (listBox_To.DataSource != null)
                employeeArr = listBox_To.DataSource as EmployeeArr;
            else
                employeeArr = new EmployeeArr();
            employeeArr.Add(employee);
            EmployeeArrToForm(listBox_To, employeeArr);
            ///הסרת הפריט הנבחר מרשימת הפריטים הנבחרים

            employeeArr = listBox_From.DataSource as EmployeeArr;
            employeeArr.Remove(employee);
            EmployeeArrToForm(listBox_From, employeeArr);
            //אם זאת הוספה לתיבת העובדים במשמרת - סימון שתי השורה האחרונה בה וגם בתיבת הרשימה של הכמויות
            
        }
        private void listBox_Employees_DoubleClick(object sender, EventArgs e)
        {
            Employee employee = listBox_Employees.SelectedItem as Employee;
            MoveSelectedEmployeeBetweenListBox(listBox_Employees, listBox_InShiftEmployees, true);
        }
        private void listBox_EmployeesInShift_DoubleClick(object sender, EventArgs e)
        {
            Employee employee = listBox_Employees.SelectedItem as Employee;
            MoveSelectedEmployeeBetweenListBox(listBox_InShiftEmployees, listBox_Employees, true);
        }


        //המרות משמרות מהבי אל
        private void ShiftToForm(Shift shift)
        {
            string time;
            if(shift.IsMorning)
            {
                time = "Morning";
            }
            else
            {
                time = "Evening";
            }
            label_Shift.Text = shift.Date.ToLongDateString() + ", "+ time;

            EmployeeArr employeeArrInShift = new EmployeeArr();
            ShiftEmployeeArr shiftEmployeeArr = new ShiftEmployeeArr();
            shiftEmployeeArr.Fill();

            shiftEmployeeArr = shiftEmployeeArr.FilterShift(shift);
            employeeArrInShift = shiftEmployeeArr.GetEmployeeArr();
            EmployeeArrToForm(listBox_InShiftEmployees, employeeArrInShift);

            EmployeeArr employeeArrNotInShift = new EmployeeArr();
            employeeArrNotInShift.Fill();

            int y = employeeArrNotInShift.Count;
            for (int i = 0; i < employeeArrInShift.Count; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    if ((employeeArrNotInShift[j] as Employee).Id == (employeeArrInShift[i] as Employee).Id)
                    {
                        employeeArrNotInShift.Remove(employeeArrNotInShift[j] as Employee);
                        y--;
                    }
                }
            }
            EmployeeArrToForm(listBox_Employees, employeeArrNotInShift);
        }


        //המרות משמרות-עובדים מהבי אל
        private ShiftEmployeeArr FormToShiftEmployeeArr(Shift curShift)
        {

            // יצירת אוסף העובדים למשמרת מהטופס
            // מייצרים זוגות של משמרת-עובד , המשמרת - תמיד אותה משמרת )הרי מדובר על משמרת אחת(, העובד - מגיע מרשימת העובדים שנבחרו
            ShiftEmployeeArr shiftEmployeeArr = new ShiftEmployeeArr();
            /*/
            יצירת אוסף הזוגות משמרת -עובד /*/
            ShiftEmployee shiftEmployee;

            //סורקים את כל הערכים בתיבת הרשימה של העובדים שנבחרו למשמרת
            for (int i = 0; i < listBox_InShiftEmployees.Items.Count; i++)
            {
                shiftEmployee = new ShiftEmployee();

                //המשמרת הנוכחית היא המשמרת לכל הזוגות באוסף

                shiftEmployee.Shift = curShift;

                //עובד נוכחי לזוג משמרת-עובד

                shiftEmployee.Employee = listBox_InShiftEmployees.Items[i] as Employee;

                //כמות עובד נוכחי לזוג משמרת-עובד

                //הוספת הזוג משמרת -עובד לאוסף

                shiftEmployeeArr.Add(shiftEmployee);
            }
            return shiftEmployeeArr;
        }


        //פילטר
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_IdFilter.Text != "")
            {
                id = int.Parse(textBox_IdFilter.Text);
            }

            //מייצרים אוסף של כלל המשמרות

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            //מסננים את אוסף המשמרות לפי שדות הסינון שרשם המשתמש
            employeeArr = employeeArr.Filter(id, textBox_FirstNameFilter.Text, textBox_LastNameFilter.Text,
            textBox_PhoneNumberFilter.Text);
            //מציבים בתיבת הרשימה את אוסף המשמרות

            listBox_Employees.DataSource = employeeArr;


        }


        //ניקוי טופס
        private void clear_Click(object sender, EventArgs e)
        {
            listBox_InShiftEmployees.DataSource = null;
            EmployeeArrToForm(listBox_Employees);
        }
        private void clearFilter_Click(object sender, EventArgs e)
        {
            textBox_IdFilter.Text = "";
            textBox_FirstNameFilter.Text = "";
            textBox_LastNameFilter.Text = "";
            textBox_PhoneNumberFilter.Text = "";
            EmployeeArrToForm(listBox_Employees);
        }


        //מחיקה
        private void delete_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
            System.Windows.Forms.DialogResult.Yes)
            {
                ShiftEmployeeArr shiftEmployeeArr_Old = new ShiftEmployeeArr();
                shiftEmployeeArr_Old.Fill();

                //סינון לפי המשמרת הנוכחית

                shiftEmployeeArr_Old = shiftEmployeeArr_Old.FilterShift(m_Shift);

                //מחיקת כל הפריטים באוסף המשמרת-פריט של המשמרת הנוכחית

                shiftEmployeeArr_Old.Delete();
                MessageBox.Show("Deleted");

                this.Close();
            }
            
        }

        
    }
}
