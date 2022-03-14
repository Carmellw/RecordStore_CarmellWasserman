using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordStore_CarmellWasserman.DAL;
using System.Data;


namespace RecordStore_CarmellWasserman.BL
{
    public class Client
    {
        private string m_FirstName;
        private string m_LastName;
        private int m_PhoneNumber;
        private int m_ZipCode;
        private City m_City;
        private int m_Id;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public int PhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
        public int ZipCode { get => m_ZipCode; set => m_ZipCode = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        public City City { get => m_City; set => m_City = value; }




        public void Insert()
        {
            Client_Dal.Insert(m_FirstName, m_LastName, m_PhoneNumber, m_ZipCode, m_City.Id);
        }

        public Client() { }

        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_PhoneNumber = (int)dataRow["PhoneNumber"];
            m_ZipCode = (int)dataRow["ZipCode"];
            this.m_Id = (int)dataRow["id"];
            DataRow dr = dataRow.GetParentRow("ClientCity");
            if (dr != null)
            {
                m_City = new City(dataRow.GetParentRow("ClientCity"));
            }
        }

        public override string ToString()
        { return $"{m_LastName} {m_FirstName}"; }

        public bool Update()
        {
            return Client_Dal.Update(m_Id, m_FirstName, m_LastName, m_PhoneNumber, m_ZipCode, m_City.Id);
        }

        public bool Delete()
        {
            return Client_Dal.Delete(m_Id);
        }




    }
}
