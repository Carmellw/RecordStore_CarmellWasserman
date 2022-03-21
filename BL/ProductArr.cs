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
    public class ProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Product_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Product curProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curProduct = new Product(dataRow);
                this.Add(curProduct);
            }
        }

        public ProductArr Filter(int id, string name, Category category= null, Artist artist = null)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Product product = (this[i] as Product);
                if (

                //סינון לפי שם המוצר
                (id == 0 || product.Id == id) &&
                product.Name.ToLower().StartsWith(name.ToLower())

                //סינון לפי החברה
                && (artist == null || artist.Id == -1 || product.Artist.Id == artist.Id)
                //סינון לפי קטגוריה
                && (category == null || category.Id == -1 || product.Category.Id == category.Id)
                )

                    //המוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    productArr.Add(product);
            }
            return productArr;
        }

        public bool DoesExist(Category curCategory)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Category.Id == curCategory.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Genre curGenre)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Genre.Id == curGenre.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Artist curArtist)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Artist.Id == curArtist.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Company curCompany)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Company.Id == curCompany.Id)
                    return true;

            return false;
        }



    }
}
