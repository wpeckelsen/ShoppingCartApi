using ShoppingCartApi.Models;

namespace ShoppingCartApi.Service
{

    public class Service
    {


        public static Dictionary<int, ShoppingCart> shoppingCartStorage = new Dictionary<int, ShoppingCart>();

        // creates a dictionary with a product ID and the amount (for example, product A is ordered 3 times by one user)
        // nothing is returned, a cart with an item+quantity is simply created
        public static void createShoppingCart(int productId, int productQuantity)
        {
            Dictionary<int, int> productDictionary = new Dictionary<int, int>();
            productDictionary.Add(productId, productQuantity);
            ShoppingCart shoppingCart = new ShoppingCart(productDictionary);
            // get id from shoppingcart
            int shoppingCartId = shoppingCart.Id;
            shoppingCartStorage.Add(shoppingCartId, shoppingCart);            
            // return shoppingCart;
        }

        public ShoppingCart returnSingleShoppingCart(int shoppingCartId){
            var foundShoppingCart = shoppingCartStorage[shoppingCartId];
            return foundShoppingCart;
        }

        public Product ReturnSingleProduct(int productId)
        {
            Product foundProduct = ProductRepository.ReturnSingleProductById(productId);
            return foundProduct;
        }

        public List<Product> ReturnAllProducts()
        {
            List<Product> allProducts = ProductRepository.ReturnAllProducts();
            return allProducts;
        }
    }

}