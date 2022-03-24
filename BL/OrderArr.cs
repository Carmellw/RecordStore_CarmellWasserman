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




    }
}
