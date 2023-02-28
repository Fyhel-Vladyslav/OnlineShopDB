using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnlineShop.Interfaces;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OnlineShop.Data
{
    public class DBConnection
    {
        public ItemDB items;
        public CategoryDB categories;
        //private readonly IConfiguration config;

        //public DBConnection(IConfiguration _conf)
        //{
        //    config = _conf;
        //}


        public class ItemDB : IAllItems
        {
            private readonly IConfiguration config;
            public ItemDB(IConfiguration _conf) => config = _conf;

            private IEnumerable<Item> allItems;


            public IEnumerable<Item> Items
            {
                get
                {
                    if (allItems != null)
                        return allItems;
                    allItems = GetItemsFromDB();
                    return allItems;
                }
            }

            public IEnumerable<Item> getFavItems 
            {
                get { return GetItemsByFavFromDB(); }
            }

            public IEnumerable<Item> getCategoryItems(int categoryId)
            {
                allItems = GetItemsFromDB(categoryId);
                return allItems;
            }

            public Item getObjectItem(int itemId)
            {
                List<Item> items = GetItemsFromDB(0, itemId);
                Item item = items.FirstOrDefault();
                return item;

                //return GetItemsFromDB(0, itemId).First();
            }


            private List<Item> GetItemsFromDB( int categoryId =0 ,int itemId=-1)
            {
                using (SqlConnection connection = new SqlConnection(config.GetConnectionString("ItemsConnection")))
                {
                    List<Item> allItems = new List<Item>();
                    connection.Open();
                    allItems.Clear();
                    SqlCommand com = new SqlCommand();
                    com.Connection = connection;
                    if (categoryId != 0)
                    {
                        if (categoryId != 0)
                            com.CommandText = $"select * from Items WHERE categoryID = {categoryId}";
                        else
                            com.CommandText = $"select * from Items";
                    }
                    else                    
                        com.CommandText = $"select * from Items WHERE id = {itemId}";
                    
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        allItems.Add(new Item((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], "", (double)reader[5], Convert.ToBoolean((byte)reader[6]), ((int)reader[7]), ((int)reader[8]), ((int)reader[9])));
                    }

                    connection.Close();

                    return allItems;
                }
            }
            private List<Item> GetItemsByFavFromDB()
            {
                using (SqlConnection connection = new SqlConnection(config.GetConnectionString("ItemsConnection")))
                {
                    List<Item> allItems = new List<Item>();
                    connection.Open();
                    allItems.Clear();
                    SqlCommand com = new SqlCommand();
                    com.Connection = connection;
                        com.CommandText = $"select * from Items WHERE isFavourite = true";
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        allItems.Add(new Item((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], "", (double)reader[5], true, ((int)reader[7]), ((int)reader[8]), ((int)reader[9])));
                    }

                    connection.Close();

                    return allItems;
                }
            }
        }




        public class CategoryDB : IAllCategories
        {
            private readonly IConfiguration config;
            public CategoryDB(IConfiguration _conf)=> config = _conf;
            

            private IEnumerable<Category> allCategories;
            IEnumerable<Category> IAllCategories.AllCategories
            {
                get
                {
                    if (allCategories!=null)
                        return allCategories;
                    allCategories = GetCategoriesFromDB();
                    return allCategories;
                }
            }
            private List<Category> GetCategoriesFromDB()
            {
                using (SqlConnection connection = new SqlConnection(config.GetConnectionString("ItemsConnection")))
                {
                    List<Category> allCategories = new List<Category>();
                    connection.Open();
                    SqlCommand com = new SqlCommand();
                    com.Connection = connection;
                    com.CommandText = "select * from Categories";
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        allCategories.Add(new Category((int)reader[0], (string)reader[1], (string)reader[2], null));
                    }
                    connection.Close();

                    return allCategories;
                }
            }
        }

        
    }
}
