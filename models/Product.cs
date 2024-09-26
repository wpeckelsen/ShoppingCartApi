namespace ShoppingCartApi.Models
{
    public class Product
    {



        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Size { get; set; }
        public string Material { get; set; }
        public int Stock { get; set; }

        public Product(int id, string name, double price, double size, string material, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Size = size;
            Material = material;
            Stock = stock;
        }

    }

}