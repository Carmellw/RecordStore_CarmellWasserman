using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RecordStore_CarmellWasserman.DAL
{
    public class ShiftEmployee_Dal
    {
        public static bool Insert(int shift, int employee)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_ShiftEmployee"
            + "("
            + "[Shift],[Employee]"
            + ")"
            + " VALUES "
            + "("
            + $"{shift},{employee}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_ShiftEmployee"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_ShiftEmployee", "[Shift]");

            DataRelation dataRelationShift = null;
            Shift_Dal.FillDataSet(dataSet);
            dataRelationShift = new DataRelation(

            //שם קשר הגומלין

            "ShiftEmployeeShift"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Shift"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_ShiftEmployee"].Columns["Shift"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelationShift);

            DataRelation dataRelationEmployee = null;
            Employee_Dal.FillDataSet(dataSet);
            dataRelationEmployee = new DataRelation(

            //שם קשר הגומלין

            "ShiftEmployeeEmployee"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Employee"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_ShiftEmployee"].Columns["Employee"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelationEmployee);

        }

        public static bool Update(int Id, int shift, int employee)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_ShiftEmployee SET"

            + $",[Shift] = {shift}"
            + $",[Employee] = {employee}"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_ShiftEmployee WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}
