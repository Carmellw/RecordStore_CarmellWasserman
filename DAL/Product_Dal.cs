using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace RecordStore_CarmellWasserman.DAL
{
    public class Product_Dal
    {
        public static bool Insert(int category, string name, int genre, int artist, int company, int isNew, int price, int count)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Product"
            + "("
            + "[Category],[Name],[Genre],[Artist],[Company],[IsNew],[Price],[Count]"
            + ")"
            + " VALUES "
            + "("
            + $"{category},'{name}',{genre},{artist},{company},{isNew},{price},{count}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Product"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Product", "[Name]");

            DataRelation dataRelationCategory = null;
            Category_Dal.FillDataSet(dataSet);
            dataRelationCategory = new DataRelation(

            //שם קשר הגומלין

            "ProductCategory"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Category"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Product"].Columns["Category"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelationCategory);

            DataRelation dataRelationGenre = null;
            Genre_Dal.FillDataSet(dataSet);
            dataRelationGenre = new DataRelation(

            //שם קשר הגומלין

            "ProductGenre"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Genre"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Product"].Columns["Genre"],false);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelationGenre);

            DataRelation dataRelationArtist = null;
            Artist_Dal.FillDataSet(dataSet);
            dataRelationArtist = new DataRelation(

            //שם קשר הגומלין

            "ProductArtist"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Artist"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Product"].Columns["Artist"],false);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelationArtist);

            DataRelation dataRelationCompany = null;
            Company_Dal.FillDataSet(dataSet);
            dataRelationCompany = new DataRelation(

            //שם קשר הגומלין

            "ProductCompany"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Company"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Product"].Columns["Company"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelationCompany);

        }

        public static bool Update(int Id, int category, string name, int genre, int artist, int company, int isNew, int price, int count)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Product SET"

            + $",[Category] = {category}"
            + $" [Name] = N'{name}'"
            + $",[Genre] = {genre}"
            + $",[Artist] = {artist}"
            + $",[Company] = {company}"
            + $",[IsNew] = {isNew}"
            + $",[Price] = {price}"
            + $",[Count] = {count}"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Product WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool UpdateCount(int id, int count)
        {

            // מעדכנת את מלאי המוצר במסד הנתונים
            string str = $"UPDATE Table_Product SET [Count] = {count} WHERE ID = {id}";
            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
