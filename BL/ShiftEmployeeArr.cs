using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using RecordStore_CarmellWasserman.DAL;


namespace RecordStore_CarmellWasserman.BL
{
    public class ShiftEmployeeArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל המשמרת-עובד

            DataTable dataTable = ShiftEmployee_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף המשמרת-עובד
            //להעביר כל שורה בטבלה למשמרת-עובד

            DataRow dataRow;
            ShiftEmployee curShiftEmployee;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curShiftEmployee = new ShiftEmployee(dataRow);
                this.Add(curShiftEmployee);
            }
        }

        public ShiftEmployeeArr FilterShift(Shift shift)
        {
            ShiftEmployeeArr shiftEmployeeArr = new ShiftEmployeeArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                ShiftEmployee shiftEmployee = (this[i] as ShiftEmployee);
                if (shiftEmployee.Shift.Id == shift.Id)
                {
                    //המוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    shiftEmployeeArr.Add(shiftEmployee);
                }
            }
            return shiftEmployeeArr;
        }

        public ShiftEmployeeArr FilterEmployee(Employee employee)
        {
            ShiftEmployeeArr shiftEmployeeArr = new ShiftEmployeeArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                ShiftEmployee shiftEmployee = (this[i] as ShiftEmployee);
                if (shiftEmployee.Employee.Id == employee.Id)

                    //המוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    shiftEmployeeArr.Add(shiftEmployee);
            }
            return shiftEmployeeArr;
        }

        public ShiftEmployeeArr FilterMonth(int month)
        {
            ShiftEmployeeArr shiftEmployeeArr = new ShiftEmployeeArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                ShiftEmployee shiftEmployee = (this[i] as ShiftEmployee);
                if (shiftEmployee.Shift.Date.Month == month)
                {
                    //המוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    shiftEmployeeArr.Add(shiftEmployee);
                }
            }
            return shiftEmployeeArr;
        }



        public bool DoesExist(Shift curShift)
        {


            for (int i = 0; i < this.Count; i++)
                if ((this[i] as ShiftEmployee).Shift.Id == curShift.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Employee curEmployee)
        {

            //מחזירה האם לפחות לאחד מהמשמרת-עובד יש את העובד

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as ShiftEmployee).Employee.Id == curEmployee.Id)
                    return true;

            return false;
        }

        public bool Insert()
        {


            ShiftEmployee shiftEmployee = null;
            for (int i = 0; i < this.Count; i++)
            {
                shiftEmployee = (this[i] as ShiftEmployee);
                if (!shiftEmployee.Insert())
                    return false;
            }
            return true;
        }

        public ShiftEmployee GetShiftEmployeeWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            ShiftEmployee maxShiftEmployee = new ShiftEmployee();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as ShiftEmployee).Id > maxShiftEmployee.Id)
                {
                    maxShiftEmployee = this[i] as ShiftEmployee;
                }
            }

            return maxShiftEmployee;
        }

        public EmployeeArr GetEmployeeArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            EmployeeArr employeeArr = new EmployeeArr();
            for (int i = 0; i < this.Count; i++)
                employeeArr.Add((this[i] as ShiftEmployee).Employee);
            return employeeArr;
        }

        public void Remove(EmployeeArr employeeArr)
        {

            //מסירה מהאוסף הנוכחי את האוסף המתקבל

            for (int i = 0; i < employeeArr.Count; i++)
                this.Remove(employeeArr[i] as Employee);
        }
        public void Remove(Employee employee)
        {

            //מסירה מהאוסף הנוכחי את הפריט המתקבל

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Employee).Id == employee.Id)
                {
                    this.RemoveAt(i); return;
                }
        }

        public bool Delete()
        {

            //מוחקת את אוסף המוצרים להזמנה ממסד הנתונים

            for (int i = 0; i < this.Count; i++)
                (this[i] as ShiftEmployee).Delete();
            return true;
        }

        public SortedDictionary<string, int> GetSortedDictionary(Employee employee)
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();

            dictionary.Add("Morning", this.FilterEmployee(employee).Filter(true).Count);
            dictionary.Add("Evening", this.FilterEmployee(employee).Filter(false).Count);
            
            // מחזירה משתנה מסוג מילון ממוין עם ערכים רלוונטיים לדוח


            return dictionary;
        }

        public ShiftEmployeeArr Filter(bool isMorning)
        {
            ShiftEmployeeArr shiftEmployeeArr = new ShiftEmployeeArr();
            ShiftEmployee shiftEmployee;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המשמרת-עובד הנוכחי במשתנה עזר - משמרת-עובד

                shiftEmployee = (this[i] as ShiftEmployee);


                if (shiftEmployee.Shift.IsMorning == isMorning)
                {

                    shiftEmployeeArr.Add(shiftEmployee);
                }
            }

            return shiftEmployeeArr;
        }





    }
}
