using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordStore_CarmellWasserman.DAL;
using System.Data;


namespace RecordStore_CarmellWasserman.BL
{
    public class Company
    {
        private string m_Name;
        private int m_Id;
        

        public string Name { get => m_Name; set => m_Name = value; }
        public int Id { get => m_Id; set => m_Id = value; }


        public void Insert()
        {
            Company_Dal.Insert(m_Name);
        }

        public Company() { }

        public Company(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_Name = dataRow["Name"].ToString();
            this.m_Id = (int)dataRow["id"];
        }

        public override string ToString()
        { return $"{m_Name}"; }

        public bool Update()
        {
            return Company_Dal.Update( m_Id , m_Name);
        }

        public bool Delete()
        {
            return Company_Dal.Delete(m_Id);
        }


        



    }
}
