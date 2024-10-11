// using System.IO;
using Newtonsoft.Json;
// using System.Collections.Generic;
// using ShoppingCartApi.Models;

namespace ShoppingCartApi.Models
{

    public static class ProductRepository
    {
        public static List<Product> ReturnAllProducts()
        {

            try
            {
                //  use ./ instead of a full path name
                string jsonFilePath = "/Users/wessel/vscode/shoppingcartapi/db/MockData.json";


                string json = File.ReadAllText(jsonFilePath);

                var result = JsonConvert.DeserializeObject<List<Product>>(json);
                if (result == null)
                {
                    throw new Exception("Unable to read Json Data");
                }

                return result;
            }
            catch
            {
                throw;
            }
        }


        public static Product ReturnSingleProduct(int productId)
        {

            string jsonFilePath = "/Users/wessel/vscode/shoppingcartapi/db/MockData.json";
            string json = File.ReadAllText(jsonFilePath);
            try
            {

                List<Product> result = JsonConvert.DeserializeObject<List<Product>>(json);
                Product foundProduct = result.FirstOrDefault(product => product.Id == productId);



                if (result == null)
                {
                    throw new Exception("unable to find JSON data!");
                }

                if (foundProduct == null)
                {
                    throw new Exception("No matching ID found in database!");
                }


                return foundProduct;
            }
            catch
            {
                throw;
            }



        }
    }
}