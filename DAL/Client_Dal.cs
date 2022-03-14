using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RecordStore_CarmellWasserman.DAL
{
    public class Client_Dal
    {
        public static bool Insert(string firstName, string lastName, int phoneNumber, int zipCode, int city)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[PhoneNumber],[ZipCode],[City]"
            + ")"
            + " VALUES "
            + "("
            + $"'{firstName}','{lastName}',{phoneNumber},{zipCode},{city}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Client", "[LastName],[FirstName]");

            DataRelation dataRelation = null;
            City_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "ClientCity"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_City"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Client"].Columns["City"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);

        }

        public static bool Update(int Id, string firstName, string lastName, int phoneNumber, int zipCode, int city)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"

            + $" [FirstName] = N'{firstName}'"
            + $",[LastName] = N'{lastName}'"
            + $",[PhoneNumber] = {phoneNumber}"
            + $",[ZipCode] = {zipCode}"
            + $",[City] = {city}"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Client WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}
