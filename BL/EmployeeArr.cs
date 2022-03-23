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
    public class EmployeeArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Employee_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Employee curEmployee;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curEmployee = new Employee(dataRow);
                this.Add(curEmployee);
            }
        }

        public EmployeeArr Filter(int id, string firstName, string lastName, string cellNumber)
        {
            EmployeeArr employeeArr = new EmployeeArr();
            Employee employee;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                employee = (this[i] as Employee);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || employee.Id == id)
                && employee.FirstName.ToLower().StartsWith(firstName.ToLower())
                && employee.LastName.ToLower().StartsWith(lastName.ToLower())
                && employee.PhoneNumber.ToString().Contains(cellNumber)
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    employeeArr.Add(employee);
            }
            return employeeArr;
        }

        



    }
}
