using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordStore_CarmellWasserman.DAL;
using System.Data;


namespace RecordStore_CarmellWasserman.BL
{
    public class Employee
    {
        private string m_FirstName;
        private string m_LastName;
        private int m_PhoneNumber;
        private string m_Email;
        private int m_HourlyWage;
        private string m_Username;
        private string m_Password;
        private int m_Id;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public int PhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
        public int HourlyWage { get => m_HourlyWage; set => m_HourlyWage = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public string Username { get => m_Username; set => m_Username = value; }
        public string Password { get => m_Password; set => m_Password = value; }

        public void Insert()
        {
            Employee_Dal.Insert(m_FirstName, m_LastName, m_PhoneNumber, m_Email, m_HourlyWage, m_Username, m_Password);
        }

        public Employee() { }

        public Employee(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_PhoneNumber = (int)dataRow["PhoneNumber"];
            m_Email = dataRow["Email"].ToString();
            m_HourlyWage = (int)dataRow["HourlyWage"];
            m_Username = dataRow["Username"].ToString();
            m_Password = dataRow["Password"].ToString();
            this.m_Id = (int)dataRow["id"];
            
        }

        public override string ToString()
        { return $"{m_LastName} {m_FirstName}"; }

        public bool Update()
        {
            return Employee_Dal.Update(m_Id, m_FirstName, m_LastName, m_PhoneNumber, m_Email, m_HourlyWage, m_Username, m_Password);
        }

        public bool Delete()
        {
            return Employee_Dal.Delete(m_Id);
        }

       





    }
}
