
using System.Globalization;

namespace ShoppingCartApi.Models
{

    public class ShoppingCart
    {
        Random rnd = new Random();
        public int Id { get; private set; }
        public int MaxProducts = 10;

        public Dictionary<int, int> ProductQuantity { get; set; }

        public ShoppingCart( Dictionary<int, int> productQuantity)
        {
            Id = rnd.Next();
            ProductQuantity = productQuantity;
        }

    }
}