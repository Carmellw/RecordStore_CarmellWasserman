﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordStore_CarmellWasserman.DAL;
using System.Data;


namespace RecordStore_CarmellWasserman.BL
{
    public class Product
    {
        private Category m_Category;
        private string m_Name;
        private Genre m_Genre;
        private Artist m_Artist;
        private Company m_Company;
        private bool m_IsNew;
        private int m_Price;
        private int m_Count;
        private int m_Id;

        public Category Category { get => m_Category; set => m_Category = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public Genre Genre { get => m_Genre; set => m_Genre = value; }
        public Artist Artist { get => m_Artist; set => m_Artist = value; }
        public Company Company { get => m_Company; set => m_Company = value; }
        public bool IsNew { get => m_IsNew; set => m_IsNew = value; }
        public int Price { get => m_Price; set => m_Price = value; }
        public int Count { get => m_Count; set => m_Count = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        




        public void Insert()
        {
            Product_Dal.Insert(m_Category.Id, m_Name, m_Genre.Id, m_Artist.Id, m_Company.Id, Convert.ToInt32(m_IsNew), m_Price, m_Count);
        }

        public Product() { }
        public Product(DataRow dataRow)
        {

            //מייצרת מוצר מתוך שורת מוצר
            DataRow drCatergory = dataRow.GetParentRow("ProductCategory");
            m_Category = new Category(dataRow.GetParentRow("ProductCategory"));

            m_Name = dataRow["Name"].ToString();

            DataRow drGenre = dataRow.GetParentRow("ProductGenre");
            if (drGenre != null)
            {
                m_Genre = new Genre(dataRow.GetParentRow("ProductGenre"));
            }

            DataRow drArtist = dataRow.GetParentRow("ProductArtist");
            if (drArtist != null)
            {
                m_Artist = new Artist(dataRow.GetParentRow("ProductArtist"));
            }

            DataRow drCompany = dataRow.GetParentRow("ProductCompany");
            m_Company = new Company(dataRow.GetParentRow("ProductCompany"));

            m_IsNew = (bool)dataRow["IsNew"];
            m_Price = (int)dataRow["Price"];
            m_Count = (int)dataRow["Count"];
            this.m_Id = (int)dataRow["id"];
            
        }

        public override string ToString()
        {
            string name = "";
            if(m_Artist != null)
            {
                name = "- " +m_Artist.Name;
            }
            if (m_Count > 0)
                return $"{m_Name} {name} ({m_Count} In stock)";
            else
                return $"{m_Name} {name} (Out of stock)";
        }

        public bool Update()
        {
            return Product_Dal.Update(m_Id, m_Category.Id, m_Name, m_Genre.Id, m_Artist.Id, m_Company.Id, Convert.ToInt32(m_IsNew), m_Price, m_Count);
        }

        public bool Delete()
        {
            return Product_Dal.Delete(m_Id);
        }

        public bool UpdateCount()
        { return Product_Dal.UpdateCount(m_Id, m_Count); }




    }
}
