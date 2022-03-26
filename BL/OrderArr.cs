﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using RecordStore_CarmellWasserman.DAL;
using System.Globalization;


namespace RecordStore_CarmellWasserman.BL
{
    public class OrderArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Order_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Order curOrder;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrder = new Order(dataRow);
                this.Add(curOrder);
            }
        }

        public OrderArr Filter(int id, Client client, DateTime fromDate, DateTime toDate)
        {
            OrderArr orderArr = new OrderArr();
            Order order;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                order = (this[i] as Order);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || order.Id == id)
                && (client == null || client.Id == -1 || order.Client.Id == client.Id)
                && (fromDate == null || order.Date >= fromDate)
                && (toDate == null || order.Date <= toDate)

                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    orderArr.Add(order);
            }
            return orderArr;
        }

        public bool DoesExist(Order curOrder)
        {


            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).Client.Id == curOrder.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Client curClient)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).Client.Id == curClient.Id)
                    return true;

            return false;
        }

        public Order GetOrderWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Order maxOrder = new Order();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Order).Id > maxOrder.Id)
                {
                    maxOrder = this[i] as Order;
                }
            }

            return maxOrder;
        }

        public OrderArr Filter(int year, int month)
        {

            //מחזירה את אוסף ההזמנות מאותה שנה ואותו חודש

            OrderArr returnArr = new OrderArr();
            foreach (Order item in this)
                if (item.Date.Year == year && item.Date.Month == month)
                    returnArr.Add(item);
            return returnArr;
        }
        public Dictionary<string, int> GetDictionary(int year)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות ההזמנות לאותו חודש

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                dictionary.Add(monthName, this.Filter(year, i).Count);
            }
            return dictionary;
        }

        public Dictionary<string, int> GetDictionaryClient(int year)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות ההזמנות לאותו חודש

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                dictionary.Add(monthName, this.Filter(year, i).Count);
            }
            return dictionary;
        }


    }
}
