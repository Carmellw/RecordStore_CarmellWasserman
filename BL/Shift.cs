using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordStore_CarmellWasserman.DAL;
using System.Data;


namespace RecordStore_CarmellWasserman.BL
{
    public class Shift
    {   
        private DateTime m_Date;
        private bool m_IsMorning;
        private int m_Id ;

        public DateTime Date { get => m_Date; set => m_Date = value; }
        public bool IsMorning { get => m_IsMorning; set => m_IsMorning = value; }
        public int Id { get => m_Id; set => m_Id = value; }




        public bool Insert()
        {
            return (Shift_Dal.Insert(m_Date, Convert.ToInt32(m_IsMorning)));
        }

        public Shift() { }

        

        public Shift(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח
            
            m_Date = Convert.ToDateTime(dataRow["Date"].ToString());
            m_IsMorning = (bool)dataRow["IsMorning"];
            this.m_Id = (int)dataRow["id"];
            DataRow dr = dataRow.GetParentRow("ShiftClient");
            
        }

        public override string ToString()
        {
            string time;
            if(m_IsMorning)
            {
                time = "Morning";
            }
            else
            {
                time = "Evening";
            }
            return $"{m_Date.ToLongDateString()} {time}"; 
        }

        public bool Update()
        {
            return Shift_Dal.Update(m_Id, m_Date, Convert.ToInt32(m_IsMorning));
        }

        public bool Delete()
        {
            return Shift_Dal.Delete(m_Id);
        }




    }
}
