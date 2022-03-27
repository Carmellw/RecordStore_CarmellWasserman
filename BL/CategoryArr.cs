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
    public class CategoryArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הקטגוריות

            DataTable dataTable = Category_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הקטגוריות
            //להעביר כל שורה בטבלה לקטגוריה

            DataRow dataRow;
            Category curCategory;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCategory = new Category(dataRow);
                this.Add(curCategory);
            }
        }

        public CategoryArr Filter(int id, string name)
        {
            CategoryArr cityArr = new CategoryArr();
            Category city;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הקטגוריה הנוכחי במשתנה עזר - קטגוריה

                city = (this[i] as Category);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || city.Id == id)
                && city.Name.ToLower().StartsWith(name.ToLower())

                )

                    //הקטגוריה ענה לדרישות הסינון - הוספת הקטגוריה לאוסף הקטגוריות המוחזר

                    cityArr.Add(city);
            }
            return cityArr;
        }

        public bool IsContains(string cityName)
        {

            //בדיקה האם יש קטגוריה עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Category).Name == cityName)
                    return true;
            return false;
        }

        public Category GetCategoryWithMaxId()
        {

            //מחזירה את הקטגוריה עם המזהה הגבוה ביותר

            Category maxCategory = new Category();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Category).Id > maxCategory.Id)
                {
                    maxCategory = this[i] as Category;
                }
            }

            return maxCategory;
        }

    



    }
}
