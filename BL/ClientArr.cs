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
    public class ClientArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Client_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Client curClient;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curClient = new Client(dataRow);
                this.Add(curClient);
            }
        }

        public ClientArr Filter(int id, string firstName, string lastName, string cellNumber)
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                client = (this[i] as Client);
                string phoneNumber = client.PhoneNumber.ToString();
                if (!(phoneNumber.Length > 999999999))
                {
                    phoneNumber = "0" + phoneNumber;
                }
                
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || client.Id == id)
                && client.FirstName.ToLower().StartsWith(firstName.ToLower())
                && client.LastName.ToLower().StartsWith(lastName.ToLower())
                && phoneNumber.StartsWith(cellNumber)
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    clientArr.Add(client);
            }
            return clientArr;
        }

        public bool DoesExist(City curCity)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Client).City.Id == curCity.Id)
                    return true;

            return false;
        }

        public SortedDictionary<string, int> GetSortedDictionary()
        {

            // מחזירה משתנה מסוג מילון ממוין עם ערכים רלוונטיים לדוח
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            CityArr clientsCityArr = this.GetCityArr();
            foreach (City curCity in clientsCityArr)
                dictionary.Add(curCity.Name, this.Filter(curCity).Count);
            return dictionary;
        }

        public CityArr GetCityArr()
        {
            CityArr cityArr = new CityArr();
            for (int i = 0; i < this.Count; i++)
            {
                if(!(cityArr.IsContains((this[i] as Client).City.Name)))
                {
                    cityArr.Add((this[i] as Client).City);
                }
            }
            return cityArr;
        }
        public ClientArr Filter(City city)
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                client = (this[i] as Client);


                if (client.City.Name == city.Name)
                {

                    clientArr.Add(client);
                }
            }

            return clientArr;
        }

        public bool DoesExist(Client curClient)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Client).Id == curClient.Id)
                    return true;

            return false;
        }



    }
}
