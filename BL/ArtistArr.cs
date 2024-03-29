﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using RecordStore_CarmellWasserman.DAL;


namespace RecordStore_CarmellWasserman.BL
{
    public class ArtistArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל האמנים

            DataTable dataTable = Artist_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף האמנים
            //להעביר כל שורה בטבלה לאמן

            DataRow dataRow;
            Artist curArtist;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curArtist = new Artist(dataRow);
                this.Add(curArtist);
            }
        }

        public ArtistArr Filter(int id, string name)
        {
            ArtistArr cityArr = new ArtistArr();
            Artist city;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת האמן הנוכחי במשתנה עזר - אמן

                city = (this[i] as Artist);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || city.Id == id)
                && city.Name.ToLower().StartsWith(name.ToLower())

                )

                    //האמן ענה לדרישות הסינון - הוספת האמן לאוסף האמנים המוחזר

                    cityArr.Add(city);
            }
            return cityArr;
        }

        public bool IsContains(string cityName)
        {

            //בדיקה האם יש אמן עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Artist).Name == cityName)
                    return true;
            return false;
        }

        public Artist GetArtistWithMaxId()
        {

            //מחזירה את האמן עם המזהה הגבוה ביותר

            Artist maxArtist = new Artist();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Artist).Id > maxArtist.Id)
                {
                    maxArtist = this[i] as Artist;
                }
            }

            return maxArtist;
        }

    



    }
}
