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
    public class OrderProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל ההזמנה-מוצר

            DataTable dataTable = OrderProduct_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף ההזמנה-מוצר
            //להעביר כל שורה בטבלה להזמנה-מוצר

            DataRow dataRow;
            OrderProduct curOrderProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrderProduct = new OrderProduct(dataRow);
                this.Add(curOrderProduct);
            }
        }

        public OrderProductArr FilterOrder(Order order)
        {
            OrderProductArr orderProductArr = new OrderProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                OrderProduct orderProduct = (this[i] as OrderProduct);
                if (orderProduct.Order.Id == order.Id)

                    //המוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }

        public OrderProductArr FilterProduct(Product product)
        {
            OrderProductArr orderProductArr = new OrderProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                OrderProduct orderProduct = (this[i] as OrderProduct);
                if (orderProduct.Product.Id == product.Id)

                    //המוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }


        public bool DoesExist(Order curOrder)
        {

            //מחזירה האם לפחות לאחד מההזמנה-מוצר יש את היהזמנה-מוצר

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as OrderProduct).Order.Id == curOrder.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Product curProduct)
        {

            //מחזירה האם לפחות לאחד מההזמנה-מוצר יש את המוצר

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

            //מחזירה את ההזמנה-מוצר עם המזהה הגבוה ביותר

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

        public ProductArr GetProductArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            ProductArr productArr = new ProductArr();
            for (int i = 0; i < this.Count; i++)
                productArr.Add((this[i] as OrderProduct).Product);
            return productArr;
        }

        public void Remove(ProductArr productArr)
        {

            //מסירה מהאוסף הנוכחי את האוסף המתקבל

            for (int i = 0; i < productArr.Count; i++)
                this.Remove(productArr[i] as Product);
        }
        public void Remove(Product product)
        {

            //מסירה מהאוסף הנוכחי את הפריט המתקבל

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Id == product.Id)
                {
                    this.RemoveAt(i); return;
                }
        }

        public bool Delete()
        {

            //מוחקת את אוסף המוצרים להזמנה ממסד הנתונים

            for (int i = 0; i < this.Count; i++)
                (this[i] as OrderProduct).Delete();
            return true;
        }

        public Dictionary<string, int> GetDictionaryRecord()
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות ההזמנות לאותו חודש
            Category category = new Category();
            category.Id = 1;

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            ProductArr productArr = GetProductArr(category);
            Product product = new Product();
            for (int i = 0; i < productArr.Count; i++)
            {
                product = productArr[i] as Product;
                dictionary.Add(product.ToString(), this.Filter(product).Count);
            }
            return dictionary;
        }

        public ProductArr GetProductArr(Category category)
        {
            ProductArr productArr = new ProductArr();
            for (int i = 0; i < this.Count; i++)
            {
                if (!(productArr.DoesExist((this[i] as OrderProduct).Product))
                    && (this[i] as OrderProduct).Product.Category.Id == category.Id)
                {
                    productArr.Add((this[i] as OrderProduct).Product);
                }


            }

            return productArr;
        }

        public OrderProductArr Filter(Product product)
        {

            //מחזירה את אוסף ההזמנות מאותה שנה ואותו חודש

            OrderProductArr returnProductArr = new OrderProductArr();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderProduct).Product.Id == product.Id)
                {
                    returnProductArr.Add(this[i] as Product);
                }
            }
            return returnProductArr;
        }
    }
}
