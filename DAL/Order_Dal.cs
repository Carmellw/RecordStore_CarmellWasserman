using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RecordStore_CarmellWasserman.DAL
{
    public class Order_Dal
    {
        public static bool Insert(int client, DateTime date, string note)
        {

            //מוסיפה את ההזמנה למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Order"
            + "("
            + "[Client],[Date],[Note]"
            + ")"
            + " VALUES "
            + "("
            + $"{client},'{date:yyyy-MM-dd}','{note}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Order"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת ההזמנות
            Dal.FillDataSet(dataSet, "Table_Order", "[Note]");

            DataRelation dataRelation = null;
            Client_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "OrderClient"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Client"].Columns["Id"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Order"].Columns["Client"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);

        }

        public static bool Update(int Id, int client, DateTime date, string note)
        {

            //מעדכנת את ההזמנה במסד הנתונים

            string str = "UPDATE Table_Order SET"

            + $"[Client] = {client}"
            + $",[Date]   = '{date:yyyy-MM-dd}'"
            + $" ,[Note] = N'{note}'"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את ההזמנה ממסד הנתונים

            string str = $"DELETE FROM Table_Order WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}
