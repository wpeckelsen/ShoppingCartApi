
namespace ShoppingCartApi.Models
{

    public class ShoppingCart
    {
        public int Id { get; set; }
        public int MaxProducts { get; set; }
        
        public Dictionary<int, int> ProductQuantity { get; set; }

        public ShoppingCart(int id, int maxProducts, Dictionary<int, int> productQuantity)
        {
            Id = id;
            MaxProducts = maxProducts;
            ProductQuantity = productQuantity;
        }

    }
}