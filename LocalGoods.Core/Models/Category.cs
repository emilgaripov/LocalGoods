using System.Collections.ObjectModel;

namespace LocalGoods.Core.Models
{
#nullable disable
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}