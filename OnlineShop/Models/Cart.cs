using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Cart
    {
        public Cart()
        {

        }

        public IEnumerable<CartLine> Lines { get { return lineCollection; } }

        private List<CartLine> lineCollection = new List<CartLine>();


        public void AddItem(Item item, int quantity)
        {
            CartLine line = lineCollection.Where(b => b.Item.id == item.id).FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine { Item = item, Quantity = quantity });
            }
            else
                line.Quantity += quantity;
        }
        public void RemoveLine(Item item)
        {
            lineCollection.RemoveAll(l => l.Item.id == item.id);
        }

        public double ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Item.price * e.Quantity);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }
    }

    public class CartLine
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
