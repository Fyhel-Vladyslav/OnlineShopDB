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
        private readonly IConfiguration config;
        public DBConnection(IConfiguration _conf)
        {
            config = _conf;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(config.GetConnectionString("ItemsConnection"));
            }
        }


        public class ItemDB:IAllItems
        {
            public IEnumerable<Item> Items => throw new NotImplementedException();

            public IEnumerable<Item> getFavItems => throw new NotImplementedException();

            public IEnumerable<Item> getCategoryItems(int categoryId)
            {
                throw new NotImplementedException();
            }

            public Item getObjectItem(int itemId)
            {
                throw new NotImplementedException();
            }
        }




        public class CategoryDB : IAllCategories
        {
            public IEnumerable<Category> AllCategories => throw new NotImplementedException();
        }

        public Item GetSimpleItemFromDB(int Id = 0)
        {
            using (SqlConnection connection = Connection)
            {
                Item item = null;
                connection.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = connection;

                com.CommandText = $"select * from Items WHERE id = {Id}";
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                    item = new Item((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], "", (double)reader[5], Convert.ToBoolean((byte)reader[6]), ((int)reader[7]), Id, ((int)reader[9]));

                connection.Close();
                return item;
            }
        }
    }
}
