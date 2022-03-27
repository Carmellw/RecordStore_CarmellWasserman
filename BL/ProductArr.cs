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

            //להביא מה-DAL טבלה מלאה בכל המוצרים

            DataTable dataTable = Product_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף המוצרים
            //להעביר כל שורה בטבלה למוצר

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

            //מחזירה האם לפחות לאחד מהמוצרים יש את הקטגוריה

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Category.Id == curCategory.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Genre curGenre)
        {

            //מחזירה האם לפחות לאחד מהמוצרים יש את הגאנר

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Genre.Id == curGenre.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Artist curArtist)
        {

            //מחזירה האם לפחות לאחד מהמוצרים יש את האומן

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Artist.Id == curArtist.Id)
                    return true;

            return false;
        }

        public bool DoesExist(Company curCompany)
        {

            //מחזירה האם לפחות לאחד מהמוצרים יש את החברה

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Company.Id == curCompany.Id)
                    return true;

            return false;
        }

        public void UpdateCount()
        {

            //מעדכנת את אוסף המוצרים

            for (int i = 0; i < this.Count; i++)
            {
                (this[i] as Product).UpdateCount();
            }
        }

        public void UpdateProduct(Product product)
        {

            //מעדכנת את הכמות של הפריט באוסף הנוכחי

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Id == product.Id)
                {
                    this[i] = product;
                    return;
                }
        }

        public bool DoesExist(Product curProduct)
        {

            //מחזירה האם לפחות לאחד מהמוצרים יש את הימוצר

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Id == curProduct.Id)
                    return true;

            return false;
        }

        public SortedDictionary<string, int> GetSortedDictionary(int i)
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            if (i == 0)
            {
                CategoryArr productsCategoryArr = this.GetCategoryArr();
                foreach (Category curCategory in productsCategoryArr)
                    dictionary.Add(curCategory.Name, this.Filter(curCategory).Count);

            }

            else if (i == 1)
            {
                GenreArr productsGenreArr = this.GetGenreArr();
                foreach (Genre curGenre in productsGenreArr)
                    dictionary.Add(curGenre.Name, this.Filter(curGenre).Count);
            }

            else if (i == 2)
            {
                dictionary.Add("New", this.Filter(true).Count);
                dictionary.Add("Second Hand", this.Filter(false).Count);
            }
            // מחזירה משתנה מסוג מילון ממוין עם ערכים רלוונטיים לדוח


            return dictionary;
        }

        public CategoryArr GetCategoryArr()
        {
            CategoryArr categoryArr = new CategoryArr();
            for (int i = 0; i < this.Count; i++)
            {
                if (!(categoryArr.IsContains((this[i] as Product).Category.Name)))
                {
                    categoryArr.Add((this[i] as Product).Category);
                }
            }
            return categoryArr;
        }
        public ProductArr Filter(Category category)
        {
            ProductArr productArr = new ProductArr();
            Product product;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                product = (this[i] as Product);


                if (product.Category.Name == category.Name)
                {

                    productArr.Add(product);
                }
            }

            return productArr;
        }
        public GenreArr GetGenreArr()
        {
            GenreArr genreArr = new GenreArr();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).Genre != null)
                {
                    if (!(genreArr.IsContains((this[i] as Product).Genre.Name)))
                    {
                        genreArr.Add((this[i] as Product).Genre);
                    }
                }
            }
            return genreArr;
        }
        public ProductArr Filter(Genre genre)
        {
            ProductArr productArr = new ProductArr();
            Product product;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                product = (this[i] as Product);

                if (product.Genre != null)
                {
                    if (product.Genre.Name == genre.Name)
                    {

                        productArr.Add(product);
                    }
                }
            }

            return productArr;
        }
        public ProductArr Filter(bool isNew)
        {
            ProductArr productArr = new ProductArr();
            Product product;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                product = (this[i] as Product);


                if (product.IsNew == isNew)
                {

                    productArr.Add(product);
                }
            }

            return productArr;
        }

    }
}
