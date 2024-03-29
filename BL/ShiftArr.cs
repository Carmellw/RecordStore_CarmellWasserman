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
    public class ShiftArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל המשמרות

            DataTable dataTable = Shift_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף המשמרות
            //להעביר כל שורה בטבלה למשמרת

            DataRow dataRow;
            Shift curShift;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curShift = new Shift(dataRow);
                this.Add(curShift);
            }
        }

        public ShiftArr Filter(int id, DateTime fromDate, DateTime toDate)
        {
            ShiftArr shiftArr = new ShiftArr();
            Shift shift;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המשמרת הנוכחי במשתנה עזר - משמרת

                shift = (this[i] as Shift);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || shift.Id == id)
                && (fromDate == null || shift.Date >= fromDate)
                && (toDate == null || shift.Date <= toDate)

                )

                    //המשמרת ענה לדרישות הסינון - הוספת המשמרת לאוסף המשמרות המוחזר

                    shiftArr.Add(shift);
            }
            return shiftArr;
        }

    

        public Shift GetShiftWithMaxId()
        {

            //מחזירה את המשמרת עם המזהה הגבוה ביותר

            Shift maxShift = new Shift();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Shift).Id > maxShift.Id)
                {
                    maxShift = this[i] as Shift;
                }
            }

            return maxShift;
        }

        public Shift GetShiftId(DateTime date, bool isMorning)
        {
            Shift shift = new Shift();
            for (int i = 0; i < this.Count; i++)
            {
                if((this[i] as Shift).Date == date &&
                    (this[i] as Shift).IsMorning == isMorning)
                {
                    shift = this[i] as Shift;
                }
            }

            return shift;
        }

        public bool DoesExist(DateTime dateTime, bool isMorning)
        {

            //מחזירה האם לפחות לאחד מהמשמרות יש את העובד

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Shift).Date == dateTime && (this[i] as Shift).IsMorning == isMorning)
                    return true;

            return false;
        }
        


    }
}
