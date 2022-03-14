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
    public class CityArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = City_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            City curCity;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCity = new City(dataRow);
                this.Add(curCity);
            }
        }

        public CityArr Filter(int id, string name)
        {
            CityArr cityArr = new CityArr();
            City city;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                city = (this[i] as City);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || city.Id == id)
                && city.Name.ToLower().StartsWith(name.ToLower())

                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    cityArr.Add(city);
            }
            return cityArr;
        }

        public bool IsContains(string cityName)
        {

            //בדיקה האם יש ישוב עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as City).Name == cityName)
                    return true;
            return false;
        }

        public City GetCityWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            City maxCity = new City();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as City).Id > maxCity.Id)
                {
                    maxCity = this[i] as City;
                }
            }

            return maxCity;
        }

    



    }
}
