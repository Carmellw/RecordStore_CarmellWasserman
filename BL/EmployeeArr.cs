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

            //להביא מה-DAL טבלה מלאה בכל העובדים

            DataTable dataTable = Employee_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף העובדים
            //להעביר כל שורה בטבלה לעובד

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

                //הצבת העובד הנוכחי במשתנה עזר - עובד

                employee = (this[i] as Employee);
                string phoneNumber = employee.PhoneNumber.ToString();
                if (!(phoneNumber.Length > 999999999))
                {
                    phoneNumber = "0" + phoneNumber;
                }
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || employee.Id == id)
                && employee.FirstName.ToLower().StartsWith(firstName.ToLower())
                && employee.LastName.ToLower().StartsWith(lastName.ToLower())
                && phoneNumber.StartsWith(cellNumber)
                )

                    //העובד ענה לדרישות הסינון - הוספת העובד לאוסף העובדים המוחזר

                    employeeArr.Add(employee);
            }
            return employeeArr;
        }

        public bool IsLogIn(string username, string password)
        {
            EmployeeArr employeeArr = new EmployeeArr();
            Employee employee;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת העובד הנוכחי במשתנה עזר - עובד

                employee = (this[i] as Employee);
                if(username == employee.Username && password == employee.Password)
                {
                    return true;
                }
                
                


            }
            return false;
        }



    }
}
