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
    public partial class Form_ShiftAdd : Form
    {
        private Shift m_Shift;
        public Form_ShiftAdd(Shift shift, bool isNew)
        {
            InitializeComponent();
            EmployeeArrToForm(listBox_Employees);
            m_Shift = shift;
            if(!isNew)
            {
                label_Id.Text = shift.Id.ToString();
            }
            ShiftToForm(shift);
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
            //אם זאת הוספה לתיבת המוצרים בהזמנה - סימון שתי השורה האחרונה בה וגם בתיבת הרשימה של הכמויות
            
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
            //employeeArrNotInShift.Remove(employeeArrInShift);
            EmployeeArrToForm(listBox_Employees, employeeArrNotInShift);
        }

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

                        //מוסיפים את הפריטים החדשים להזמנה

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
                    

                    //מוחקים את הפריטים הקודמים של ההזמנה
                    //אוסף כלל הזוגות - הזמנה-פריט

                    ShiftEmployeeArr shiftEmployeeArr_Old = new ShiftEmployeeArr();
                    shiftEmployeeArr_Old.Fill();

                    //סינון לפי ההזמנה הנוכחית

                    shiftEmployeeArr_Old = shiftEmployeeArr_Old.FilterShift(shift);

                    //מחיקת כל הפריטים באוסף ההזמנה-פריט של ההזמנה הנוכחית

                    shiftEmployeeArr_Old.Delete();

                    //מוסיפים את הפריטים לפי העדכני להזמנה

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

        private ShiftEmployeeArr FormToShiftEmployeeArr(Shift curShift)
        {

            // יצירת אוסף המוצרים להזמנה מהטופס
            // מייצרים זוגות של הזמנה-מוצר , ההזמנה - תמיד אותה הזמנה )הרי מדובר על הזמנה אחת(, המוצר - מגיע מרשימת המוצרים שנבחרו
            ShiftEmployeeArr shiftEmployeeArr = new ShiftEmployeeArr();
            /*/
            יצירת אוסף הזוגות הזמנה -מוצר /*/
            ShiftEmployee shiftEmployee;

            //סורקים את כל הערכים בתיבת הרשימה של המוצרים שנבחרו להזמנה
            for (int i = 0; i < listBox_InShiftEmployees.Items.Count; i++)
            {
                shiftEmployee = new ShiftEmployee();

                //ההזמנה הנוכחית היא ההזמנה לכל הזוגות באוסף

                shiftEmployee.Shift = curShift;

                //מוצר נוכחי לזוג הזמנה-מוצר

                shiftEmployee.Employee = listBox_InShiftEmployees.Items[i] as Employee;

                //כמות מוצר נוכחי לזוג הזמנה-מוצר

                //הוספת הזוג הזמנה -מוצר לאוסף

                shiftEmployeeArr.Add(shiftEmployee);
            }
            return shiftEmployeeArr;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox_InShiftEmployees.DataSource = null;
            EmployeeArrToForm(listBox_Employees);
        }

        private void delete_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
            System.Windows.Forms.DialogResult.Yes)
            {
                ShiftEmployeeArr shiftEmployeeArr_Old = new ShiftEmployeeArr();
                shiftEmployeeArr_Old.Fill();

                //סינון לפי ההזמנה הנוכחית

                shiftEmployeeArr_Old = shiftEmployeeArr_Old.FilterShift(m_Shift);

                //מחיקת כל הפריטים באוסף ההזמנה-פריט של ההזמנה הנוכחית

                shiftEmployeeArr_Old.Delete();
                MessageBox.Show("Deleted");

                this.Close();
            }
            
        }

        
    }
}
