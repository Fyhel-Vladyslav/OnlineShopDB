using OnlineShop.Models;
using System.Collections.Generic;

namespace OnlineShop.Interfaces
{
    public interface IAllCategories
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
