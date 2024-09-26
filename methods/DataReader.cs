using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using ShoppingCartApi.Models;


namespace ShoppingCartApi.methods
{
    public static class DataReader
    {
        public static List<Product> LoadAllProductsFromJson()
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

    }
}