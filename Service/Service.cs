using ShoppingCartApi.Models;

namespace ShoppingCartApi.Service
{

    public class Service
    {


        // function that can create ShoppingCart + declare quantity of product
        public ShoppingCart createShoppingCart(int productId, int productQuantity)
        {
            Dictionary<int, int> productDictionary = new Dictionary<int, int>();
            
            productDictionary.Add(productId, productQuantity);

            ShoppingCart shoppingCart = new ShoppingCart(productDictionary);

            return shoppingCart;
        }
    }

}