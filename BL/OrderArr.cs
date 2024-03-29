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

            //להביא מה-DAL טבלה מלאה בכל ההזמנות

            DataTable dataTable = Order_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף ההזמנות
            //להעביר כל שורה בטבלה להזמנה

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

                //הצבת ההזמנה הנוכחי במשתנה עזר - הזמנה

                order = (this[i] as Order);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || order.Id == id)
                && (client == null || client.Id == -1 || order.Client.Id == client.Id)
                && (fromDate == null || order.Date >= fromDate)
                && (toDate == null || order.Date <= toDate)

                )

                    //ההזמנה ענה לדרישות הסינון - הוספת ההזמנה לאוסף ההזמנות המוחזר

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

            //מחזירה האם לפחות לאחד מההזמנות יש את היהזמנה

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).Client.Id == curClient.Id)
                    return true;

            return false;
        }

        public Order GetOrderWithMaxId()
        {

            //מחזירה את ההזמנה עם המזהה הגבוה ביותר

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
            {
                if (item.Date.Year == year && item.Date.Month == month)
                {
                    returnArr.Add(item);
                }
            }
            return returnArr;
        }
        public SortedDictionary<int, int> GetSortedDictionary(int year)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות ההזמנות לאותו חודש

            SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                int monthName = i ;
                dictionary.Add(monthName, this.Filter(year, i).Count);
            }
            return dictionary;
        }

        public OrderArr Filter(int day)
        {

            //מחזירה את אוסף ההזמנות מאותה שנה ואותו חודש

            OrderArr returnArr = new OrderArr();
            foreach (Order item in this)
            {
                if ((int)item.Date.DayOfWeek == day)
                {
                    returnArr.Add(item);
                }
            }
            return returnArr;
        }

        public SortedDictionary<int, int> GetSortedDictionary()
        {


            SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
            for (int i = 0; i <= 6; i++)
            {

                int dayName = i + 1;
                dictionary.Add(dayName, this.Filter(i).Count);
            }
            return dictionary;
        }



        public Dictionary<string, int> GetDictionaryClient()
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות ההזמנות לאותו חודש

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            ClientArr clientArr = GetClientArr();
            Client client = new Client();
            for (int i = 0; i < clientArr.Count; i++)
            {
                client = clientArr[i] as Client;
                dictionary.Add(client.ToString(), this.Filter(client).Count);
            }
            return dictionary;
        }

        public ClientArr GetClientArr()
        {
            ClientArr clientArr = new ClientArr();
            for (int i = 0; i < this.Count; i++)
            {
                if(!(clientArr.DoesExist((this[i] as Order).Client)))
                {
                    clientArr.Add((this[i] as Order).Client);
                }


            }

            return clientArr;
        }

        public OrderArr Filter(Client client)
        {

            //מחזירה את אוסף ההזמנות מאותה שנה ואותו חודש

            OrderArr returnArr = new OrderArr();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Order).Client.Id == client.Id)
                {
                    returnArr.Add(this[i] as Client);
                }
            }
            return returnArr;
        }


    }
}
