using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordStore_CarmellWasserman.DAL;
using System.Data;


namespace RecordStore_CarmellWasserman.BL
{
    public class ShiftEmployee
    {
        private Shift m_Shift;
        private Employee m_Employee;
        private int m_Id;

        public Shift Shift { get => m_Shift; set => m_Shift = value; }
        public Employee Employee { get => m_Employee; set => m_Employee = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        




        public bool Insert()
        {
            return (ShiftEmployee_Dal.Insert(m_Shift.Id, m_Employee.Id));
        }

        public ShiftEmployee() { }
        public ShiftEmployee(DataRow dataRow)
        {

            //מייצרת משמרת-עובד מתוך שורת משמרת-עובד
            DataRow drCatergory = dataRow.GetParentRow("ShiftEmployeeShift");
            m_Shift = new Shift(dataRow.GetParentRow("ShiftEmployeeShift"));

            DataRow drEmployee = dataRow.GetParentRow("ShiftEmployeeEmployee");
            m_Employee = new Employee(dataRow.GetParentRow("ShiftEmployeeEmployee"));


            this.m_Id = (int)dataRow["id"];
            
        }

        public override string ToString()
        { return $"{m_Employee}"; }

        public bool Update()
        {
            return ShiftEmployee_Dal.Update(m_Id, m_Shift.Id, m_Employee.Id);
        }

        public bool Delete()
        {
            return ShiftEmployee_Dal.Delete(m_Id);
        }




    }
}
