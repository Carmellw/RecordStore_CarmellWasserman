using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RecordStore_CarmellWasserman.DAL
{
    public class Genre_Dal
    {
        public static bool Insert(string name)
        {

            //מוסיפה את הגאנר למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Genre"
            + "("
            + "[Name]"
            + ")"
            + " VALUES "
            + "("
            + $"'{name}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Genre"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלה הנוכחית - בתנאי שהטבלה לא נמצאת כבר באוסף

            if (!dataSet.Tables.Contains("Table_Genre"))
            {
                Dal.FillDataSet(dataSet, "Table_Genre", "[Name]");
            }
        }

        public static bool Update(int Id, string name)
        {

            //מעדכנת את הגאנר במסד הנתונים

            string str = "UPDATE Table_Genre SET"

            + $" [Name] = N'{name}'"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הגאנר ממסד הנתונים

            string str = $"DELETE FROM Table_Genre WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }


    }
}
