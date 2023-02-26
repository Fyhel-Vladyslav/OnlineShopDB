using OnlineShop.Models;
using System.Collections.Generic;

namespace OnlineShop.Interfaces
{
    public interface IAllItems
    {

        IEnumerable<Item> Items { get; }

        IEnumerable<Item> getFavItems { get; }

        IEnumerable<Item> getCategoryItems(int categoryId);

        Item getObjectItem(int itemId);
    }
}
