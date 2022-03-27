using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordStore_CarmellWasserman.DAL;
using System.Data;


namespace RecordStore_CarmellWasserman.BL
{
    public class OrderProduct
    {
        private Order m_Order;
        private Product m_Product;
        private int m_Count;
        private int m_Id;

        public Order Order { get => m_Order; set => m_Order = value; }
        public Product Product { get => m_Product; set => m_Product = value; }
        public int Count { get => m_Count; set => m_Count = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        




        public bool Insert()
        {
            return (OrderProduct_Dal.Insert(m_Order.Id, m_Product.Id, m_Count));
        }

        public OrderProduct() { }
        public OrderProduct(DataRow dataRow)
        {

            //מייצרת הזמנה-מוצר מתוך שורת הזמנה-מוצר
            DataRow drCatergory = dataRow.GetParentRow("OrderProductOrder");
            m_Order = new Order(dataRow.GetParentRow("OrderProductOrder"));

            DataRow drProduct = dataRow.GetParentRow("OrderProductProduct");
            m_Product = new Product(dataRow.GetParentRow("OrderProductProduct"));

            m_Count = (int)dataRow["Count"];

            this.m_Id = (int)dataRow["id"];
            
        }

        public override string ToString()
        { return $"{m_Product}"; }

        public bool Update()
        {
            return OrderProduct_Dal.Update(m_Id, m_Order.Id, m_Product.Id, m_Count);
        }

        public bool Delete()
        {
            return OrderProduct_Dal.Delete(m_Id);
        }




    }
}
