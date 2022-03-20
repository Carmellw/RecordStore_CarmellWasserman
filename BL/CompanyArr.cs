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
    public class CompanyArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Company_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Company curCompany;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCompany = new Company(dataRow);
                this.Add(curCompany);
            }
        }

        public CompanyArr Filter(int id, string name)
        {
            CompanyArr cityArr = new CompanyArr();
            Company city;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                city = (this[i] as Company);
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
                if ((this[i] as Company).Name == cityName)
                    return true;
            return false;
        }

        public Company GetCompanyWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Company maxCompany = new Company();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Company).Id > maxCompany.Id)
                {
                    maxCompany = this[i] as Company;
                }
            }

            return maxCompany;
        }

    



    }
}
