using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RecordStore_CarmellWasserman.DAL
{
    public class OrderProduct_Dal
    {
        public static bool Insert(int order, int product, int count)
        {

            //מוסיפה את ההזמנה-מוצר למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_OrderProduct"
            + "("
            + "[Order],[Product],[Count]"
            + ")"
            + " VALUES "
            + "("
            + $"{order},{product},{count}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_OrderProduct"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת ההזמנה-מוצר
            Dal.FillDataSet(dataSet, "Table_OrderProduct", "[Product]");

            DataRelation dataRelationOrder = null;
            Order_Dal.FillDataSet(dataSet);
            dataRelationOrder = new DataRelation(

            //שם קשר הגומלין

            "OrderProductOrder"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Order"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_OrderProduct"].Columns["Order"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelationOrder);

            DataRelation dataRelationProduct = null;
            Product_Dal.FillDataSet(dataSet);
            dataRelationProduct = new DataRelation(

            //שם קשר הגומלין

            "OrderProductProduct"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Product"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_OrderProduct"].Columns["Product"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelationProduct);

        }

        public static bool Update(int Id, int order, int product, int count)
        {

            //מעדכנת את ההזמנה-מוצר במסד הנתונים

            string str = "UPDATE Table_OrderProduct SET"

            + $",[Order] = {order}"
            + $",[Product] = {product}"
            + $",[Count] = {count}"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את ההזמנה-מוצר ממסד הנתונים

            string str = $"DELETE FROM Table_OrderProduct WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}
