namespace LocalGoods.Resources
{
#nullable disable
    public class ProductResource
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public CategoryResource Category { get; set; }
    }
}
