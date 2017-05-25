using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ProductStoreApp.DAL.Model;

namespace ProductStoreApp.DAL.Gateway
{
    public class ItemsGateway:CommonGateway
    {
        public int Save(Item aItem)
        {
            Query = "INSERT INTO Product VALUES('" + aItem.Code + "','" + aItem.Description + "','" + aItem.Quantity +"')";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Item IsCodeExistItem(string code)
        {
            Query = "SELECT * FROM Product WHERE Code='" + code + "'";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Item aItem = null;
            if (Reader.Read())
            {
                aItem=new Item();
                aItem.Code = Reader["Code"].ToString();
                aItem.Description = Reader["Description"].ToString();
                aItem.Quantity = Convert.ToInt32(Reader["Quantity"]);
            }
            Reader.Close();
            Connection.Close();
            return aItem;
        }

        public List<Item> GetAllProduct()
        {
            Query = "SELECT * FROM Product";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();  
          
            List<Item>AllProductList=new List<Item>();
            while (Reader.Read())
            {              
                Item aItem = new Item();
                aItem.Id = Convert.ToInt32(Reader["Id"]);
                aItem.Code = Reader["Code"].ToString();
                aItem.Description = Reader["Description"].ToString();
                aItem.Quantity = Convert.ToInt32(Reader["Quantity"]);
                AllProductList.Add(aItem);
            }
            Reader.Close();
            Connection.Close();
            return AllProductList;
        }

        public int GetUpdateQuantity(int quantity,string code)
        {

            Query = "UPDATE Product SET Quantity=Quantity+'" + quantity + "' WHERE Code='" + code + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}