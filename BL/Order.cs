using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordStore_CarmellWasserman.DAL;
using System.Data;


namespace RecordStore_CarmellWasserman.BL
{
    public class Order
    {   
        private Client m_Client;
        private DateTime m_Date;
        private string m_Note;
        private int m_Id;

        public Client Client { get => m_Client; set => m_Client = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }
        public string Note { get => m_Note; set => m_Note = value; }
        public int Id { get => m_Id; set => m_Id = value; }




        public void Insert()
        {
            Order_Dal.Insert(m_Client.Id, m_Date, m_Note);
        }

        public Order() { }

        public Order(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח
            
            m_Client = new Client(dataRow.GetParentRow("OrderClient"));
            m_Date = Convert.ToDateTime(dataRow["Date"].ToString());
            m_Note = dataRow["Note"].ToString();
            this.m_Id = (int)dataRow["id"];
            DataRow dr = dataRow.GetParentRow("OrderClient");
            
        }

        public override string ToString()
        { return $"{m_Client.LastName} {m_Client.FirstName} {m_Date.ToLongDateString()}"; }

        public bool Update()
        {
            return Order_Dal.Update(m_Id, m_Client.Id, m_Date, m_Note);
        }

        public bool Delete()
        {
            return Order_Dal.Delete(m_Id);
        }




    }
}
