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
    public class OrderProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = OrderProduct_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            OrderProduct curOrderProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrderProduct = new OrderProduct(dataRow);
                this.Add(curOrderProduct);
            }
        }

        /*/public OrderProductArr Filter(int id, Order category= null, Artist artist = null)
        {
            OrderProductArr orderProductArr = new OrderProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                OrderProduct orderProduct = (this[i] as OrderProduct);
                if (

                //סינון לפי שם המוצר
                (id == 0 || orderProduct.Id == id) &&
                orderProduct.Name.ToLower().StartsWith(name.ToLower())

                //סינון לפי החברה
                && (artist == null || artist.Id == -1 || orderProduct.Artist.Id == artist.Id)
                //סינון לפי קטגוריה
                && (category == null || category.Id == -1 || orderProduct.Order.Id == category.Id)
                )

                    //המוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }
        /*/

        public bool DoesExist(Order curOrder)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as OrderProduct).Order.Id == curOrder.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Product curProduct)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as OrderProduct).Product.Id == curProduct.Id)
                    return true;

            return false;
        }

        public bool Insert()
        {

            // מוסיפה את אוסף המוצרים להזמנה למסד הנתונים

            OrderProduct orderProduct = null;
            for (int i = 0; i < this.Count; i++)
            {
                orderProduct = (this[i] as OrderProduct);
                if (!orderProduct.Insert())
                    return false;
            }
            return true;
        }

        



        public OrderProduct GetOrderProductWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            OrderProduct maxOrderProduct = new OrderProduct();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderProduct).Id > maxOrderProduct.Id)
                {
                    maxOrderProduct = this[i] as OrderProduct;
                }
            }

            return maxOrderProduct;
        }


    }
}
