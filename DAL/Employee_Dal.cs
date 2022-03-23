using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RecordStore_CarmellWasserman.DAL
{
    public class Employee_Dal
    {
        public static bool Insert(string firstName, string lastName, int phoneNumber, string email, int hourlyWage, string username, string password)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Employee"
            + "("
            + "[FirstName],[LastName],[PhoneNumber],[Email],[HourlyWage],[Username],[Password]"
            + ")"
            + " VALUES "
            + "("
            + $"'{firstName}','{lastName}',{phoneNumber},'{email}',{hourlyWage},'{username}','{password}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Employee"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Employee", "[LastName],[FirstName]");

            

            

        }

        public static bool Update(int Id, string firstName, string lastName, int phoneNumber, string email, int hourlyWage, string username, string password)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Employee SET"

            + $" [FirstName] = N'{firstName}'"
            + $",[LastName] = N'{lastName}'"
            + $",[PhoneNumber] = {phoneNumber}"
            + $",[Email] = '{email}'"
            + $",[HourlyWage] = {hourlyWage}"
            + $",[Username] = '{username}'"
            + $",[Password] = '{password}'"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Employee WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}
