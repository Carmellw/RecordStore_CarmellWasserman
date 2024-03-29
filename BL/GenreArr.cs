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
    public class GenreArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הגאנרים

            DataTable dataTable = Genre_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הגאנרים
            //להעביר כל שורה בטבלה לגאנר

            DataRow dataRow;
            Genre curGenre;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curGenre = new Genre(dataRow);
                this.Add(curGenre);
            }
        }

        public GenreArr Filter(int id, string name)
        {
            GenreArr cityArr = new GenreArr();
            Genre city;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הגאנר הנוכחי במשתנה עזר - גאנר

                city = (this[i] as Genre);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || city.Id == id)
                && city.Name.ToLower().StartsWith(name.ToLower())

                )

                    //הגאנר ענה לדרישות הסינון - הוספת הגאנר לאוסף הגאנרים המוחזר

                    cityArr.Add(city);
            }
            return cityArr;
        }

        public bool IsContains(string cityName)
        {

            //בדיקה האם יש גאנר עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Genre).Name == cityName)
                    return true;
            return false;
        }

        public Genre GetGenreWithMaxId()
        {

            //מחזירה את הגאנר עם המזהה הגבוה ביותר

            Genre maxGenre = new Genre();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Genre).Id > maxGenre.Id)
                {
                    maxGenre = this[i] as Genre;
                }
            }

            return maxGenre;
        }

    



    }
}
